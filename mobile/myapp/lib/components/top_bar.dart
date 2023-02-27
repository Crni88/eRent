import 'package:flutter/material.dart';
import 'package:myapp/screens/nekretnine/nekretnine_screen.dart';
import 'package:myapp/screens/payments/allpayments_screen.dart';
import 'package:myapp/screens/poruke.dart';
import 'package:shared_preferences/shared_preferences.dart';

class TopBar extends StatelessWidget {
  const TopBar({
    super.key,
    required BuildContext context,
  });

  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: const BoxDecoration(
        borderRadius: BorderRadius.all(Radius.circular(50)),
        boxShadow: [
          BoxShadow(
              color: Color(0xffa9d7f6), //New
              blurRadius: 25.0,
              offset: Offset(0, 5))
        ],
      ),
      child: Container(
        decoration: const BoxDecoration(
            color: Color(0xffa9d7f6),
            gradient: LinearGradient(colors: [
              Color.fromRGBO(143, 148, 251, 1),
              Color.fromRGBO(143, 148, 251, .6)
            ])),
        child:
            Row(mainAxisAlignment: MainAxisAlignment.spaceBetween, children: [
          _TopBarIcons(
            path: 'assets/images/home.png',
            context: context,
          ),
          Text("eRent",
              style: Theme.of(context).textTheme.displayLarge!.copyWith(
                  color: Colors.white,
                  fontWeight: FontWeight.bold,
                  fontSize: 30)),
          _TopBarIcons(
              //TODO Replace this with the payment icon
              //Add a function to the icon that will open the payment screen
              //Add payment model
              //Add payment provider
              //Add payment screen
              //Add single payment screen
              path: 'assets/images/cashless-payment.png',
              context: context,
              messages: true),
        ]),
      ),
    );
  }

  GestureDetector _TopBarIcons(
      {required String path,
      required BuildContext context,
      bool messages = false}) {
    return GestureDetector(
      onTap: () async => {
        if (messages)
          {
            Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => const AllPaymentsScreen()),
            )
          }
        else
          {
            Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => const NekretnineListScreen()),
            )
          }
      },
      child: Container(
        height: 75,
        width: 75,
        padding: const EdgeInsets.all(10),
        child: Image.asset(path),
      ),
    );
  }
}
