import 'package:flutter/material.dart';
import 'package:myapp/screens/customer/customer_profile.dart';
import 'package:myapp/screens/nekretnine/nekretnine_screen.dart';

class MyBottomBar extends StatelessWidget {
  int currentIndex = 1;
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
          icon: Icon(Icons.home),
          label: 'Home',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.person),
          label: 'Profile',
        ),
      ],
      currentIndex: currentIndex,
      onTap: (index) {
        if (index == 1) {
          Navigator.push(
            context,
            MaterialPageRoute(
                builder: (context) => const CustomerProfileScreen()),
          );
        } else {
          onTap(index);
        }
      },
    );
  }
}
