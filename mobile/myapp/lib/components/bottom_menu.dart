import 'package:flutter/material.dart';
import 'package:myapp/screens/customer/customer_profile.dart';
import 'package:myapp/screens/payments/allpayments_screen.dart';
import 'package:myapp/screens/rezervations/myreservations_screen.dart';
import 'package:myapp/screens/visits/myvisits_screen.dart';

class MyBottomBar extends StatelessWidget {
  int currentIndex = 0;
  final Function(int) onTap;

  MyBottomBar({
    Key? key,
    required this.currentIndex,
    required this.onTap,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return BottomNavigationBar(
      items: const <BottomNavigationBarItem>[
        BottomNavigationBarItem(
          icon: Icon(Icons.person),
          label: 'Profile',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.payment),
          label: 'Payments',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.calendar_month),
          label: 'Reservations',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.travel_explore),
          label: 'Visits',
        ),
      ],
      currentIndex: currentIndex,
      selectedItemColor: Colors.blue, // Set the selected item color
      unselectedItemColor: Colors.grey, // Set the unselected item color
      onTap: (index) {
        if (index == 0) {
          Navigator.push(
            context,
            MaterialPageRoute(
                builder: (context) => const CustomerProfileScreen()),
          );
        } else if (index == 1) {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const AllPaymentsScreen()),
          );
        } else if (index == 2) {
          Navigator.push(
            context,
            MaterialPageRoute(
                builder: (context) => const MyReservationsScreen()),
          );
        } else if (index == 3) {
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => const MyVisitsScreen()),
          );
        }
      },
    );
  }
}
