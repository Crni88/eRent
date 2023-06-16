import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:myapp/model/payment/payment.dart';
import 'package:myapp/providers/allpayments_provider.dart';
import 'package:myapp/screens/payments/singlepayment_screen_copy.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../components/bottom_menu.dart';
import '../../components/title.dart';

class AllPaymentsScreen extends StatefulWidget {
  const AllPaymentsScreen({super.key});

  @override
  State<AllPaymentsScreen> createState() => _AllPaymentsScreenState();
}

class _AllPaymentsScreenState extends State<AllPaymentsScreen> {
  List<Payment> payments = [];
  AllPaymentsProvider allPaymentsProvider = AllPaymentsProvider();
  @override
  void initState() {
    // TODO: implement initState
    super.initState();
    loadData();
  }

  Future loadData() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? korisnikId = prefs.getString('korisnikId');
    var search = {
      "KorisnikPaymentId": korisnikId,
    };
    var temp3 = await allPaymentsProvider.get(search);
    setState(() {
      payments = temp3;
    });
  }

  int _selectedIndex = 1;

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Column(
        children: [
          const MyTitle("All payments"),
          Expanded(
            child: ListView.builder(
                itemCount: payments.length,
                itemBuilder: (context, index) {
                  return GestureDetector(
                    onTap: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) =>
                                SinglePaymentScreen_Copy(payments[index])),
                      );
                    },
                    child: ListTile(
                      title: Text(payments[index].naslov!),
                      subtitle: Text(payments[index].komentar!),
                      trailing: Text(
                        payments[index].isProcessed != null &&
                                payments[index].isProcessed!
                            ? 'Processed'
                            : payments[index].iznos.toString(),
                        style: TextStyle(
                          color: payments[index].isProcessed != null &&
                                  payments[index].isProcessed!
                              ? Colors
                                  .red // Set the color to red for processed text
                              : null, // Use the default color for non-processed text
                          fontWeight: payments[index].isProcessed != null &&
                                  payments[index].isProcessed!
                              ? FontWeight
                                  .bold // Set the font weight to bold for processed text
                              : null, // Use the default font weight for non-processed text
                        ),
                      ),
                    ),
                  );
                }),
          ),
          MyBottomBar(
            currentIndex: _selectedIndex,
            onTap: _onItemTapped,
          ),
        ],
      )),
    );
  }
}
