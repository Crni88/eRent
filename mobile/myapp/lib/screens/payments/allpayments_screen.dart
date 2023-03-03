import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:myapp/model/payment/payment.dart';
import 'package:myapp/providers/allpayments_provider.dart';
import 'package:myapp/screens/singlepayment_screen_copy.dart';
import 'package:shared_preferences/shared_preferences.dart';

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

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Column(
        children: [
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
                      trailing: Text(payments[index].iznos.toString()),
                    ),
                  );
                }),
          ),
        ],
      )),
    );
  }
}
