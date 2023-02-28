import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/model/stripe/stripecustomer.dart';
import 'package:myapp/providers/stripecustomer_provider.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../model/payment/payment.dart';
import '../../providers/addpayment_provider.dart';
import '../../providers/allpayments_provider.dart';
import '../nekretnine/nekretnine_screen.dart';

class PaymentForm extends StatefulWidget {
  late Payment payment;
  PaymentForm(this.payment, {super.key});

  @override
  _PaymentFormState createState() => _PaymentFormState(payment);
}

class _PaymentFormState extends State<PaymentForm> {
  final _formKey = GlobalKey<FormState>();
  _PaymentFormState(Payment payment);

  @override
  void initState() {
    super.initState();
    payment = widget.payment;
  }

  TextEditingController? _cardNameController = TextEditingController();
  TextEditingController? _cardNumberController = TextEditingController();
  TextEditingController? _expYearController = TextEditingController();
  TextEditingController? __expMonthController = TextEditingController();
  TextEditingController? __cvcController = TextEditingController();

  String? _cardName;
  String? _cardNumber;
  int? _expYear;
  int? _expMonth;
  int? _cvc;

  StripeCustomerProvider _stripeCustomerProvider = StripeCustomerProvider();
  AddPaymentProvider addPaymentProvider = AddPaymentProvider();
  Payment payment = Payment();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Payment Form'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Form(
          key: _formKey,
          child:
              Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
            // TextFormField(
            //   decoration: const InputDecoration(
            //     labelText: 'Name',
            //   ),
            //   validator: (value) {
            //     if (value!.isEmpty) {
            //       return 'Please enter your name';
            //     }
            //     return null;
            //   },
            //   onSaved: (value) {
            //     _name = value!;
            //   },
            // ),
            // TextFormField(
            //   decoration: const InputDecoration(
            //     labelText: 'Email',
            //   ),
            //   validator: (value) {
            //     if (value!.isEmpty) {
            //       return 'Please enter your email';
            //     } else if (!RegExp(r'\S+@\S+\.\S+').hasMatch(value)) {
            //       return 'Please enter a valid email address';
            //     }
            //     return null;
            //   },
            //   onSaved: (value) {
            //     _email = value!;
            //   },
            // ),
            // const SizedBox(height: 16.0),
            const Text(
              'Credit Card Information',
              style: TextStyle(fontSize: 18.0, fontWeight: FontWeight.bold),
            ),
            TextFormField(
              controller: _cardNameController,
              decoration: const InputDecoration(
                labelText: 'Name on card',
              ),
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter the name on your card';
                }
                return null;
              },
              onSaved: (value) {
                _cardName = value!;
              },
            ),
            TextFormField(
              controller: _cardNumberController,
              decoration: const InputDecoration(
                labelText: 'Card number',
              ),
              keyboardType: TextInputType.number,
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter your card number';
                } else if (value.length < 16) {
                  return 'Please enter a valid card number';
                }
                return null;
              },
              onSaved: (value) {
                _cardNumber = value!;
              },
            ),
            Row(
              children: [
                Expanded(
                  child: TextFormField(
                    controller: _expYearController,
                    decoration: const InputDecoration(
                      labelText: 'Expiration year',
                    ),
                    keyboardType: TextInputType.number,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return 'Please enter the expiration year';
                      } else if (value!.length < 4) {
                        return 'Please enter a valid expiration year';
                      }
                      return null;
                    },
                    onSaved: (value) {
                      _expYear = int.parse(value!);
                    },
                  ),
                ),
                const SizedBox(width: 16.0),
                Expanded(
                  child: TextFormField(
                    controller: __expMonthController,
                    decoration: const InputDecoration(
                      labelText: 'Expiration month',
                    ),
                    keyboardType: TextInputType.number,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return 'Please enter the expiration month';
                      } else if (value!.length < 2) {
                        return 'Please enter a valid expiration month';
                      }
                      return null;
                    },
                    onSaved: (value) {
                      _expMonth = int.parse(value!);
                    },
                  ),
                ),
                const SizedBox(width: 16.0),
                Expanded(
                  child: TextFormField(
                    controller: __cvcController,
                    decoration: const InputDecoration(
                      labelText: 'CVC',
                    ),
                    keyboardType: TextInputType.number,
                    validator: (value) {
                      if (value!.isEmpty) {
                        return 'Please enter the CVC';
                      } else if (value!.length < 4) {
                        return 'Please enter the CVC';
                      }
                      return null;
                    },
                    onSaved: (value) {
                      _cvc = int.parse(value!);
                    },
                  ),
                ),
              ],
            ),
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
                    SharedPreferences prefs =
                        await SharedPreferences.getInstance();
                    String? email = prefs.getString('korisnikEmail');
                    String? name = prefs.getString('korisnikImePrezime');
                    var creditCard = {
                      'name': 'Visa',
                      'cardNumber': _cardNumberController?.text,
                      'expirationYear': _expYearController?.text,
                      'expirationMonth': __expMonthController?.text,
                      'cvc': __cvcController?.text
                    };
                    var customerDetails = {
                      'name': name,
                      'email': email,
                      'creditCard': creditCard
                    };
                    var stripeCustomer =
                        await _stripeCustomerProvider.insert(customerDetails);
                    if (stripeCustomer?.customerId != null) {
                      try {
                        var stripePayment = {
                          "customerId": stripeCustomer?.customerId,
                          "receiptEmail": stripeCustomer?.email,
                          "description": payment.naslov,
                          "currency": "usd",
                          "amount": (payment.iznos! * 100).toInt(),
                        };
                        var temp =
                            await addPaymentProvider.insert(stripePayment);
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
                child: const Center(child: Text("Login")),
              ),
            ),
          ]),
        ),
      ),
    );
  }
}
