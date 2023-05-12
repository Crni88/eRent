import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/posjeta.dart';

class VisitRow extends StatelessWidget {
  const VisitRow({
    Key? key,
    required this.nazivnekretnine,
    required this.datumPosjete,
    required this.vrijemePosjete,
    required Posjeta posjeta,
    required Null Function() onCanceled,
  }) : super(key: key);

  final String? nazivnekretnine;
  final DateTime? datumPosjete;
  final String? vrijemePosjete;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8, horizontal: 16),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              const MySpacer(),
              MyTitle(nazivnekretnine ?? ""),
              const SizedBox(height: 8),
              Text(
                  'Datum Posjete: ${datumPosjete?.toString()?.substring(0, 10) ?? ""}',
                  style: const TextStyle(fontSize: 16)),
              const SizedBox(height: 4),
              Text('Vrijeme Posjete: ${vrijemePosjete ?? ""}',
                  style: const TextStyle(fontSize: 16)),
              const SizedBox(height: 8),
              ElevatedButton(
                onPressed: () {
                  // Handle cancel button press
                },
                child: const Text('Cancel', style: TextStyle(fontSize: 16)),
              ),
            ],
          )
        ],
      ),
    );
  }
}
