import 'package:flutter/material.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/providers/posjeta_provider.dart';

import '../components/mytext.dart';
import '../components/spacer.dart';
import '../components/title.dart';
import '../utils/util.dart';
import 'nekretnine/nekretnine_screen.dart';

class PosjetaScreen extends StatefulWidget {
  Nekretnina nekretnina;
  Korisnik korisnik;
  PosjetaScreen(this.nekretnina, this.korisnik, {super.key});

  @override
  State<PosjetaScreen> createState() =>
      _PosjetaScreenState(nekretnina, korisnik);
}

class _PosjetaScreenState extends State<PosjetaScreen> {
  _PosjetaScreenState(this.nekretnina, this.korisnik);
  Nekretnina nekretnina;
  Korisnik korisnik;

  DateTime startDate = DateTime(2023, 1, 1, 12, 00);
  String vrijemePosjete = "12:00";
  PosjetaProvider posjetaProvider = PosjetaProvider();

  @override
  Widget build(BuildContext context) {
    final hours = startDate.hour.toString().padLeft(2, '0');
    final minutes = startDate.minute.toString().padLeft(2, '0');
    return Scaffold(
      body: SafeArea(
          child: SingleChildScrollView(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            TopBar(context: context),
            const MySpacer(),
            SizedBox(
              height: 300,
              child: imageFromBase64String(nekretnina.slika!), //slika
            ),
            const MySpacer(),
            MyTitle(nekretnina.nazivNekretnine!),
            const MySpacer(),
            MyText(
                "Datum: ${startDate.day}/${startDate.month}/${startDate.year}",
                true),
            const MySpacer(),
            // End date
            MyText("Vrijeme: $vrijemePosjete", true),
            const MySpacer(),
            Container(
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
                    var posjetaObject = {
                      "korisnikId": korisnik.korisnikId,
                      "nekretninaId": nekretnina.nekretninaId,
                      "datumPosjete": startDate.toIso8601String(),
                      "vrijemePosjete": vrijemePosjete
                    };
                    await posjetaProvider.insert(posjetaObject);
                    showDialog(
                        context: context,
                        builder: (context) {
                          Future.delayed(const Duration(seconds: 5), () {
                            Navigator.of(context).pop(true);
                            Navigator.push(
                              context,
                              MaterialPageRoute(
                                  builder: (context) =>
                                      const NekretnineListScreen()),
                            );
                          });
                          return const AlertDialog(
                            title: Text('Uspjesno poslano'),
                          );
                        });
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
                child: const Center(child: MyText("Posalji!", true)),
              ),
            ),
          ],
        ),
      )),
      floatingActionButton: FloatingActionButton(
        onPressed: () async {
          final date = await pickDate(context);
          if (date == null) {
            return;
          } else {
            final time = await pickTime(context);
            if (time == null) {
              return;
            } else if (time.minute < 9) {
              setState(() {
                vrijemePosjete = "${time.hour}:0${time.minute}";
              });
            } else {
              setState(() {
                startDate = DateTime(
                    date.year, date.month, date.day, time.hour, time.minute);
                vrijemePosjete = "${time.hour}:${time.minute}";
              });
            }
          }
        },
        backgroundColor: Colors.blueAccent,
        child: const Icon(Icons.date_range),
      ),
    );
  }
}

Future<TimeOfDay?> pickTime(BuildContext context) => showTimePicker(
    context: context, initialTime: const TimeOfDay(hour: 12, minute: 00));

Future<DateTime?> pickDate(context) => showDatePicker(
      context: context,
      initialDate: DateTime.now(),
      firstDate: DateTime.now(),
      lastDate: DateTime(2024),
    );
