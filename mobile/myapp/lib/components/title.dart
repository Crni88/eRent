import 'package:flutter/material.dart';

class MyTitle extends StatelessWidget {
  final String title;
  const MyTitle(this.title, {super.key});

  @override
  Widget build(BuildContext context) {
    return Text(title,
        style: const TextStyle(
            color: Colors.black, fontSize: 25, fontWeight: FontWeight.bold));
  }
}
