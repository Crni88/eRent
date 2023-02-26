import 'package:flutter/material.dart';
import 'package:myapp/components/mytext.dart';

import '../screens/nekretnine/nekretnine_screen.dart';

class MyButton extends StatelessWidget {
  final String text;
  const MyButton(this.text, {super.key, required onPressed});

  @override
  Widget build(BuildContext context) {
    return Container(
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
            Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => const NekretnineListScreen()),
            );
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
        child: Center(child: MyText(text, true)),
      ),
    );
  }
}
