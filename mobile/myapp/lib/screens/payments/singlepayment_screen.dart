import 'package:flutter/material.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/payment/payment.dart';
import 'package:myapp/providers/addpayment_provider.dart';
import 'package:myapp/providers/allpayments_provider.dart';

import '../nekretnine/nekretnine_screen.dart';

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
                  try {
                    var stripePayment = {
                      "customerId": "cus_NQhvmjuzOBux4k",
                      "receiptEmail": "yoourmail@gmail.com",
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
                },
                child: const Center(child: MyText("Plati", true)),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
