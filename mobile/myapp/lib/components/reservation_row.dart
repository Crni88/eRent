import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/rezervacija.dart';

import '../providers/rezervacija_provider.dart';

class ReservationRow extends StatelessWidget {
  ReservationRow(
    Rezervacija rezervacije, {
    super.key,
    required this.mjesecnaRezervacija,
    required this.datumPocetka,
    required this.datumKraja,
    required this.imePrezime,
    required this.brojTelefona,
    required this.nazivnekretnine,
    required this.odobrena,
    required this.id,
    required this.onClick,
  });

  late bool mjesecnaRezervacija;
  late DateTime datumPocetka;
  late DateTime datumKraja;
  late String imePrezime;
  late String brojTelefona;
  late String nazivnekretnine;
  late int id;
  late bool odobrena;
  final Null Function() onClick;

  RezervacijaProvider rezervacijaProvider = RezervacijaProvider();

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: [
        Padding(
          padding: const EdgeInsets.all(8.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              const MySpacer(),
              MyTitle(nazivnekretnine),
              const SizedBox(height: 8),
              Text(
                'Datum Pocetka: ${datumPocetka.toString().substring(0, 10)}',
                style: const TextStyle(fontSize: 16),
              ),
              const SizedBox(height: 4),
              Text(
                'Datum Kraja: ${datumKraja.toString().substring(0, 10)}',
                style: const TextStyle(fontSize: 16),
              ),
              const SizedBox(height: 4),
              Text(
                'Ime Prezime: $imePrezime',
                style: const TextStyle(fontSize: 16),
              ),
              const SizedBox(height: 4),
              Text(
                'Broj Telefona: $brojTelefona',
                style: const TextStyle(fontSize: 16),
              ),
              const SizedBox(height: 4),
              Text(
                'Odobrena: ${odobrena ? 'Da' : 'Ne'}',
                style: const TextStyle(fontSize: 16),
              ),
              const SizedBox(height: 4),
              Text(
                'Mjesecna Rezervacija: ${mjesecnaRezervacija ? 'Da' : 'Ne'}',
                style: const TextStyle(fontSize: 16),
              ),
              const SizedBox(height: 8),
              ElevatedButton(
                onPressed: () async {
                  try {
                    await rezervacijaProvider.update(id, {
                      "rezervacijaId": id,
                      "odobrena": false,
                      "otkazana": true
                    });
                    onClick();
                  } catch (e) {
                    print(e);
                  }
                },
                child: const Text('Cancel'),
              ),
            ],
          ),
        ),
      ],
    );
  }
}
