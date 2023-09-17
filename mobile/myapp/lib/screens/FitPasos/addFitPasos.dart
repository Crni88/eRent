import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/providers/fitpasosprovider.dart';
import 'package:myapp/providers/user_provider.dart';
import 'package:myapp/screens/FitPasos/fitpasosscreen.dart';

class AddFitPasos extends StatefulWidget {
  static const String routeName = "/addFitPasos";
  const AddFitPasos({super.key});

  @override
  State<AddFitPasos> createState() => _AddFitPasosState();
}

class _AddFitPasosState extends State<AddFitPasos> {
  TextEditingController _pasosIdController = TextEditingController();
  TextEditingController _korisnikIdController = TextEditingController();
  DateTime date = DateTime.now();
  bool isChecked = false;
  bool _validatePasosId = false;
  bool _validatekorisnikId = false;
  FITPasosProvider fitPasosProvider = FITPasosProvider();
  UserProvider _userProvider = UserProvider();
  List<Korisnik> korisnik = [];
  List<int> korisnik_id = [];

  @override
  void initState() {
    super.initState();
    loadData();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Container(
        padding: const EdgeInsets.all(20),
        child: Column(
          children: [
            const Text("AddFitPasos"),
            const MySpacer(),
            DropdownButton<int>(
              hint: const Text("KorisnikId"),
              value: null,
              onChanged: (int? value) {
                setState(() {
                  _korisnikIdController.text = value.toString();
                });
              },
              items: korisnik_id.map((int value) {
                return DropdownMenuItem<int>(
                  value: value,
                  child: Text(value.toString()),
                );
              }).toList(),
            ),
            const MySpacer(),
            TextField(
              controller: _korisnikIdController,
              decoration: InputDecoration(
                hintText: "KorisnikId",
                errorText:
                    _validatekorisnikId ? 'Polje ne smije biti prazno!' : null,
              ),
              readOnly: true,
            ),
            const MySpacer(),
            Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  TextButton(
                    onPressed: () async {
                      final DateTime? picked = await showDatePicker(
                        context: context,
                        initialDate: date,
                        firstDate: DateTime(2015, 8),
                        lastDate: DateTime(2101),
                      );
                      if (picked != null && picked != date) {
                        setState(() {
                          date = picked;
                        });
                      }
                    },
                    child: const Text('Odaberi datum'),
                  ),
                  MyText("Datum: ${date.day}/${date.month}/${date.year}", true),
                ]),
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Checkbox(
                    value: isChecked,
                    onChanged: (value) {
                      setState(() {
                        isChecked = value!;
                      });
                    }),
                const MyText("Validan.", true)
              ],
            ),
            const MySpacer(),
            ElevatedButton(
                onPressed: () async {
                  try {
                    setState(() {
                      _validatePasosId = _pasosIdController.text.isEmpty;
                      _validatekorisnikId = _korisnikIdController.text.isEmpty;
                    });

                    if (!_validatekorisnikId) {
                      await fitPasosProvider.insert({
                        "PasosId": _pasosIdController.text,
                        "KorisnikId": _korisnikIdController.text,
                        "Datum": date.toIso8601String(),
                        "Validan": isChecked
                      });
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) => const FitPassosScreen()),
                      );
                    }
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
                child: const Text('Dodaj FitPasos'))
          ],
        ),
      )),
    );
  }

  void loadData() async {
    var _korisnik = await _userProvider.get();
    setState(() {
      korisnik = _korisnik;
    });
    getKorisnikIds();
  }

  void getKorisnikIds() {
    for (var i = 0; i < korisnik.length; i++) {
      korisnik_id.add(korisnik[i].korisnikId!);
      print("------------------KORISNIKOVI IDOVI ------------------------");
      print(korisnik_id);
    }
  }
}
