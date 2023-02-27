import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter/src/widgets/placeholder.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/payment/payment.dart';
import 'package:flutter_stripe/flutter_stripe.dart';

class SinglePaymentScreen extends StatefulWidget {
  late Payment payment;
  SinglePaymentScreen(this.payment, {super.key});

  @override
  State<SinglePaymentScreen> createState() =>
      _SinglePaymentScreenState(payment);
}

class _SinglePaymentScreenState extends State<SinglePaymentScreen> {
  _SinglePaymentScreenState(Payment payment);
  bool isShown = false;
  Payment payment = Payment();

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    payment = widget.payment;
  }

  void showCreditCard() {
    setState(() {
      isShown = true;
    });
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
                    showCreditCard();
                    // await Stripe.instance.confirmPayment(
                    //     paymentIntentClientSecret: payment.naslov!,
                    //     paymentMethodId: payment.komentar!);
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
