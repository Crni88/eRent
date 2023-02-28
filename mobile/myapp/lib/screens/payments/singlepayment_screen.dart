import 'package:flutter/material.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/payment/payment.dart';
import 'package:myapp/providers/addpayment_provider.dart';
import 'package:myapp/providers/allpayments_provider.dart';
import 'package:shared_preferences/shared_preferences.dart';

import 'dart:convert';
import 'package:http/http.dart' as http;
import '../nekretnine/nekretnine_screen.dart';
import 'addcreditcardinfo.dart';

import 'package:myapp/.env';

class SinglePaymentScreen extends StatefulWidget {
  late Payment payment;
  SinglePaymentScreen(this.payment, {super.key});

  @override
  State<SinglePaymentScreen> createState() =>
      _SinglePaymentScreenState(payment);
}

class Card {}

class _SinglePaymentScreenState extends State<SinglePaymentScreen> {
  _SinglePaymentScreenState(Payment payment);

  Payment payment = Payment();
  AddPaymentProvider addPaymentProvider = AddPaymentProvider();
  AllPaymentsProvider allPaymentsProvider = AllPaymentsProvider();
  String? _email;
  @override
  void initState() {
    super.initState();
    payment = widget.payment;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(
          children: [
            TopBar(context: context),
            MyTitle(payment.naslov!),
            MyText(payment.komentar!, false),
            MyText(payment.iznos.toString(), true),
            const MySpacer(),
            Container(
              height: 50,
              margin: const EdgeInsets.fromLTRB(40, 0, 40, 0),
              decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(10),
                gradient: const LinearGradient(colors: [
                  Color.fromRGBO(143, 148, 251, 1),
                  Color.fromRGBO(143, 148, 251, .6)
                ]),
              ),
              child: InkWell(
                onTap: () async {
                  dynamic isCustomerRegistered = await _getCurrentUser();
                  if (!isCustomerRegistered.email!.isEmpty) {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => PaymentForm(payment)),
                    );
                  } else {
                    try {
                      var stripePayment = {
                        "customerId": isCustomerRegistered.id,
                        "receiptEmail": isCustomerRegistered.email,
                        "description": payment.naslov,
                        "currency": "usd",
                        "amount": (payment.iznos! * 100).toInt(),
                      };
                      var temp = await addPaymentProvider.insert(stripePayment);
                      if (temp?.paymentId != null) {
                        var update = {
                          "paymentId": temp?.paymentId,
                          "isProcessed": true,
                          "nekretninaPayment": payment.nekretninaPayment,
                          "komentar": payment.komentar,
                          "iznos": payment.iznos,
                          "mjesecno": payment.mjesecno,
                          "nekretnina": payment.nekretnina,
                          "korisnikPaymentId": payment.korisnikPaymentId,
                        };
                        var temp2 = AllPaymentsProvider()
                            .update(payment.paymentRequestId!, update);
                        if (temp2 != null) {
                          showDialog(
                              context: context,
                              builder: (context) {
                                Future.delayed(Duration(seconds: 5), () {
                                  Navigator.of(context).pop(true);
                                  Navigator.push(
                                    context,
                                    MaterialPageRoute(
                                        builder: (context) =>
                                            const NekretnineListScreen()),
                                  );
                                });
                                return AlertDialog(
                                  title: Text('Placanje uspješno!'),
                                );
                              });
                        }
                      }
                    } catch (e) {
                      showDialog(
                          context: context,
                          builder: (BuildContext context) => AlertDialog(
                                title: const Text("Error"),
                                content: Text(e.toString()),
                                actions: [
                                  TextButton(
                                    child: const Text("Ok"),
                                    onPressed: () => Navigator.pop(context),
                                  )
                                ],
                              ));
                    }
                  }
                },
                child: const Center(child: MyText("Plati", true)),
              ),
            ),
          ],
        ),
      ),
    );
  }

  Future<dynamic> _getCurrentUser() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    setState(() {
      _email = prefs.getString('korisnikEmail');
    });
    const String apiKey = stripeSecretKey;
    // Define the URL for the Stripe API's customers endpoint
    final Uri url =
        Uri.parse('https://api.stripe.com/v1/customers?email=$_email');
    // Make a GET request to the customers endpoint with the email query parameter
    try {
      final response =
          await http.get(url, headers: {'Authorization': 'Bearer $apiKey'});
      final json = jsonDecode(response.body);
      if (json['data'].isNotEmpty) {
        final customer = json['data'][0];
        print('Customer found with email ${customer['email']}');
        return customer;
      } else {
        print('No customer found with email $_email');
        return false;
      }
    } catch (e) {
      print('Error retrieving customer: $e');
      return false;
    }
  }
}
