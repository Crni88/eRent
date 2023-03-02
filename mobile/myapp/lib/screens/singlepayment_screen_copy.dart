import 'package:flutter/material.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/payment/payment.dart';
import 'package:myapp/providers/addpayment_provider.dart';
import 'package:myapp/providers/allpayments_provider.dart';

import 'dart:convert';
import 'package:http/http.dart' as http;

import 'package:myapp/.env';

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
  AddPaymentProvider addPaymentProvider = AddPaymentProvider();
  AllPaymentsProvider allPaymentsProvider = AllPaymentsProvider();
  String? _email;

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
            MyTitle("${payment.naslov!}KOPIJA"),
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
                  // 7.5 hardkodirano - cijena koja se placa
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
                    print(
                        'Exception/DISPLAYPAYMENTSHEET==> $error $stackTrace');
                    showDialog(
                        context: context,
                        builder: (_) => const AlertDialog(
                              content: Text("Ponistena transakcija"),
                            ));
                    throw Exception("Payment declined");
                  });
                  print("payment sheet created");
                  print(paymentIntentData!['client_secret']);
                  var temp = await Stripe.instance.presentPaymentSheet();

                  // hendlat saveanje u bazu
                  _saveToDatabase(paymentIntentData!['id'], payment);
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
  var update = {
    "paymentId": paymentId,
    "isProcessed": true,
    "nekretninaPayment": payment.nekretninaPayment,
    "komentar": payment.komentar,
    "iznos": payment.iznos,
    "mjesecno": payment.mjesecno,
    "nekretnina": payment.nekretnina,
    "korisnikPaymentId": payment.korisnikPaymentId,
  };
  var temp2 = AllPaymentsProvider().update(payment.paymentRequestId!, update);
}

// Future<dynamic> _getCurrentUser() async {
//   SharedPreferences prefs = await SharedPreferences.getInstance();
//   setState(() {
//     _email = prefs.getString('korisnikEmail');
//   });
//   const String apiKey = stripeSecretKey;
//   // Define the URL for the Stripe API's customers endpoint
//   final Uri url =
//       Uri.parse('https://api.stripe.com/v1/customers?email=$_email');
//   // Make a GET request to the customers endpoint with the email query parameter
//   try {
//     final response =
//         await http.get(url, headers: {'Authorization': 'Bearer $apiKey'});
//     final json = jsonDecode(response.body);
//     if (json['data'].isNotEmpty) {
//       final customer = json['data'][0];
//       print('Customer found with email ${customer['email']}');
//       return customer;
//     } else {
//       print('No customer found with email $_email');
//       return false;
//     }
//   } catch (e) {
//     print('Error retrieving customer: $e');
//     return false;
//   }
// }
