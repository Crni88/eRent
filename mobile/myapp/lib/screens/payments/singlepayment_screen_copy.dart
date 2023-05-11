import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/payment/payment.dart';
import 'package:myapp/providers/allpayments_provider.dart';

import 'dart:convert';
import 'package:http/http.dart' as http;

import 'package:myapp/.env';

import '../nekretnine/nekretnine_screen.dart';

class SinglePaymentScreen_Copy extends StatefulWidget {
  late Payment payment;
  SinglePaymentScreen_Copy(this.payment, {super.key});

  @override
  State<SinglePaymentScreen_Copy> createState() =>
      _SinglePaymentScreenState(payment);
}

class Card {}

class _SinglePaymentScreenState extends State<SinglePaymentScreen_Copy> {
  _SinglePaymentScreenState(Payment payment);

  Payment payment = Payment();
  //AddPaymentProvider addPaymentProvider = AddPaymentProvider();
  AllPaymentsProvider allPaymentsProvider = AllPaymentsProvider();

  Map<String, dynamic>? paymentIntentData;

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
                  paymentIntentData = await createPaymentIntent(
                      (payment.iznos! * 100).round().toString(), 'bam');
                  await Stripe.instance
                      .initPaymentSheet(
                          paymentSheetParameters: SetupPaymentSheetParameters(
                              paymentIntentClientSecret:
                                  paymentIntentData!['client_secret'],
                              style: ThemeMode.dark,
                              merchantDisplayName: 'eRent'))
                      .then((value) {})
                      .onError((error, stackTrace) {
                    if (kDebugMode) {
                      print(
                          'Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
                    }
                    showDialog(
                        context: context,
                        builder: (_) => const AlertDialog(
                              content: Text("Ponistena transakcija"),
                            ));
                    throw Exception("Payment declined");
                  });
                  if (kDebugMode) {
                    print("payment sheet created");
                    print(paymentIntentData!['client_secret']);
                  }
                  try {
                    var temp = await Stripe.instance.presentPaymentSheet();
                  } catch (e) {
                    if (kDebugMode) {
                      print(e);
                    }
                  }

                  // hendlat saveanje u bazu
                  _saveToDatabase(paymentIntentData!['id'], payment);
                  showDialog(
                      context: context,
                      builder: (context) {
                        Future.delayed(const Duration(seconds: 5), () {
                          Navigator.of(context).pop(true);
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) =>
                                    const NekretnineListScreen()),
                          );
                        });
                        return const AlertDialog(
                          title: Text('Uspjesno plaćeno!'),
                        );
                      });
                },
                child: const Center(child: MyText("Plati", true)),
              ),
            ),
          ],
        ),
      ),
    );
  }

  createPaymentIntent(String amount, String currency) async {
    try {
      Map<String, dynamic> body = {
        'amount': amount,
        'currency': currency,
        'payment_method_types[]': 'card'
      };

      var response = await http.post(
          Uri.parse('https://api.stripe.com/v1/payment_intents'),
          body: body,
          headers: {
            'Authorization': 'Bearer $stripeSecretKey',
            'Content-Type': 'application/x-www-form-urlencoded'
          });
      return jsonDecode(response.body);
    } catch (err) {
      print('err charging user: ${err.toString()}');
    }
  }
}

void _saveToDatabase(String paymentId, Payment payment) {
  try {
    var update = {
      "paymentId": paymentId,
      "isProcessed": true,
      "nekretninaPayment": payment.nekretninaPayment,
      "komentar": payment.komentar,
      "iznos": payment.iznos,
      "mjesecno": payment.mjesecno,
      "nekretnina": payment.nekretnina,
      "korisnikPaymentId": payment.korisnikPaymentId,
      "naslov": payment.naslov,
    };
    var temp2 = AllPaymentsProvider().update(payment.paymentRequestId!, update);
  } catch (err) {
    print('err saving payment to database: ${err.toString()}');
  }
}
