import 'package:flutter/material.dart';

class PaymentForm extends StatefulWidget {
  @override
  _PaymentFormState createState() => _PaymentFormState();
}

class _PaymentFormState extends State<PaymentForm> {
  final _formKey = GlobalKey<FormState>();

  late String _email;
  late String _name;
  late String _cardName;
  late String _cardNumber;
  late int _expYear;
  late int _expMonth;
  late int _cvc;

  @override
  void initState() {
    // TODO: implement initState
    super.initState();
  }

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
            TextFormField(
              decoration: const InputDecoration(
                labelText: 'Name',
              ),
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter your name';
                }
                return null;
              },
              onSaved: (value) {
                _name = value!;
              },
            ),
            TextFormField(
              decoration: const InputDecoration(
                labelText: 'Email',
              ),
              validator: (value) {
                if (value!.isEmpty) {
                  return 'Please enter your email';
                } else if (!RegExp(r'\S+@\S+\.\S+').hasMatch(value)) {
                  return 'Please enter a valid email address';
                }
                return null;
              },
              onSaved: (value) {
                _email = value!;
              },
            ),
            const SizedBox(height: 16.0),
            const Text(
              'Credit Card Information',
              style: TextStyle(fontSize: 18.0, fontWeight: FontWeight.bold),
            ),
            TextFormField(
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
              ],
            ),
          ]),
        ),
      ),
    );
  }
}
