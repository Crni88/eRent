import 'package:flutter/material.dart';

class SingleNekretinaRow extends StatelessWidget {
  final String opis;
  final String data;
  final bool bold;
  const SingleNekretinaRow(
    this.data,
    this.opis,
    this.bold, {
    super.key,
  });

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.symmetric(vertical: 15),
      color: bold ? Colors.grey[200] : Colors.white,
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(data,
              style: const TextStyle(
                color: Colors.black,
                fontSize: 18,
              )),
          Text(opis,
              style: const TextStyle(
                color: Colors.black,
                fontSize: 18,
              ))
        ],
      ),
    );
  }
}
