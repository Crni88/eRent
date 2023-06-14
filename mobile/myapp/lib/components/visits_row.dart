import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/posjeta.dart';
import 'package:myapp/providers/posjeta_provider.dart';

class VisitRow extends StatelessWidget {
  VisitRow({
    Key? key,
    required this.nazivnekretnine,
    required this.datumPosjete,
    required this.vrijemePosjete,
    required Posjeta posjeta,
    required this.onClicked,
    required this.id,
  }) : super(key: key);

  final int? id;
  final String? nazivnekretnine;
  final DateTime? datumPosjete;
  final String? vrijemePosjete;
  final Null Function() onClicked;
  PosjetaProvider posjetaProvider = PosjetaProvider();

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
                onPressed: () async {
                  try {
                    await posjetaProvider.update(id!, {
                      "posjetaId": id!,
                      "datumPosjete": "OTKAZANA",
                      "vrijemePosjete": "OTKAZANA",
                      "otkazana": true
                    });
                    onClicked();
                  } catch (e) {
                    print(e);
                  }
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
