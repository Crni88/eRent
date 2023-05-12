import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/providers/rezervacija_provider.dart';

import '../../components/title.dart';
import '../../utils/util.dart';
import '../nekretnine/nekretnine_screen.dart';

class RezervacijaScreen extends StatelessWidget {
  Nekretnina nekretnina;
  Korisnik? korisnik;
  RezervacijaScreen(this.nekretnina, this.korisnik, {Key? key})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      // Remove the debug banner
      debugShowCheckedModeBanner: false,
      title: 'eRent',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: HomeScreen(nekretnina, korisnik),
    );
  }
}

class HomeScreen extends StatefulWidget {
  Nekretnina nekretnina;
  Korisnik? korisnik;

  HomeScreen(this.nekretnina, this.korisnik, {Key? key}) : super(key: key);

  @override
  State<HomeScreen> createState() => _HomeScreenState(nekretnina, korisnik);
}

class _HomeScreenState extends State<HomeScreen> {
  bool isMjesecna = false;
  late Nekretnina nekretnina;
  late Korisnik? korisnik;
  RezervacijaProvider rezervacijaProvider = RezervacijaProvider();
  // This is the selected date range
  DateTimeRange _selectedDateRange = DateTimeRange(
    start: DateTime.now(),
    end: DateTime.now().add(const Duration(days: 1)),
  );

  _HomeScreenState(this.nekretnina, this.korisnik);

  // This function will be triggered when the floating button is pressed
  void _show() async {
    final DateTimeRange? result = await showDateRangePicker(
      context: context,
      firstDate: DateTime.now(),
      lastDate: DateTime(2030, 12, 31),
      currentDate: DateTime.now(),
      saveText: 'Done',
    );

    if (result != null) {
      // Rebuild the UI
      if (kDebugMode) {
        print(result.start.toString());
      }
      setState(() {
        _selectedDateRange = result;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: SingleChildScrollView(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            TopBar(
              context: context,
            ),
            const MySpacer(),
            SizedBox(
              height: 300,
              child: imageFromBase64String(nekretnina.slika!), //slika
            ),
            const MySpacer(),
            MyTitle(nekretnina.nazivNekretnine!),
            const MySpacer(),
            _rezervacijaScreenBuild(_selectedDateRange, context),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Checkbox(
                  value: isMjesecna,
                  onChanged: (newBool) {
                    setState(() {
                      if (isMjesecna == true) {
                        _selectedDateRange = DateTimeRange(
                          start: _selectedDateRange.start,
                          end: _selectedDateRange.end
                              .subtract(const Duration(days: 30)),
                        );
                      } else {
                        _selectedDateRange = DateTimeRange(
                          start: _selectedDateRange.start,
                          end: _selectedDateRange.end
                              .add(const Duration(days: 30)),
                        );
                      }
                      isMjesecna = newBool!;
                    });
                  },
                  activeColor: Colors.blueAccent,
                ),
                const MySpacer(),
                const MyText("Mjesecna rezevacija", true),
                const MySpacer(),
              ],
            ),
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
                    //TODO Add korisnik telefon
                    var rezervacijaObject = {
                      "nekretninaId": nekretnina.nekretninaId,
                      "mjesecnaRezervacija": isMjesecna,
                      "datumPocetka":
                          _selectedDateRange.start.toIso8601String(),
                      "datumKraja": _selectedDateRange.end.toIso8601String(),
                      "imePrezime":
                          "${korisnik!.korsnikIme} ${korisnik!.korisnikPrezime}",
                      "brojTelefona": "064 4002 619",
                    };
                    await rezervacijaProvider.insert(rezervacijaObject);
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
                            title: Text('Rezervacija uspješna!'),
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
                child: const Center(child: MyText("Rezervisi!", true)),
              ),
            ),
          ],
        ),
      )),
      floatingActionButton: FloatingActionButton(
        onPressed: _show,
        backgroundColor: Colors.blueAccent,
        child: const Icon(Icons.date_range),
      ),
    );
  }
}

Widget _rezervacijaScreenBuild(
    DateTimeRange dateTimeRange, BuildContext context) {
  return Column(
    crossAxisAlignment: CrossAxisAlignment.start,
    mainAxisAlignment: MainAxisAlignment.center,
    children: [
      // Start date
      MyText(
          "Start date: ${dateTimeRange.start.toString().split(' ')[0]}", true),
      const MySpacer(),
      // End date
      MyText("End date: ${dateTimeRange.end.toString().split(' ')[0]}", true),
    ],
  );
}
