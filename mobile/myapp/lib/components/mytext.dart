import 'package:flutter/material.dart';

class MyText extends StatelessWidget {
  final String text;
  final bool isBold;
  const MyText(this.text, this.isBold, {super.key});

  @override
  Widget build(BuildContext context) {
    return Text(text,
        textAlign: TextAlign.left,
        style: TextStyle(
            color: Colors.black,
            fontSize: 18,
            fontWeight: isBold ? FontWeight.bold : FontWeight.normal));
  }
}
