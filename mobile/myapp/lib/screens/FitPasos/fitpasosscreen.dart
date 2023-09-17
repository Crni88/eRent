import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/components/visits_row.dart';
import 'package:myapp/model/fitpasos.dart';
import 'package:myapp/model/posjeta.dart';
import 'package:myapp/providers/fitpasosprovider.dart';
import 'package:myapp/screens/FitPasos/addFitPasos.dart';
import 'package:provider/provider.dart';

class FitPassosScreen extends StatefulWidget {
  const FitPassosScreen({super.key});

  @override
  State<FitPassosScreen> createState() => _FitPassosScreenState();
}

class _FitPassosScreenState extends State<FitPassosScreen> {
  FITPasosProvider? fitPasosProvider;
  List<FITPasos> fitPasos = [];
  bool isLoading = true;
  final TextEditingController _pasosIdController = TextEditingController();
  final TextEditingController _korisnikIdController = TextEditingController();
  DateTime date = DateTime.now();
  bool isChecked = false;

  @override
  void initState() {
    super.initState();
    fitPasosProvider = context.read<FITPasosProvider>();
    loadData();
  }

  Future loadData() async {
    var temp3 = await fitPasosProvider?.get();
    setState(() {
      fitPasos = temp3!;
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(
          children: [
            const MyTitle("FIT Pasosi"),
            Row(
              mainAxisAlignment: MainAxisAlignment.end,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                ElevatedButton(
                    onPressed: () => {
                          Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => const AddFitPasos()),
                          )
                        },
                    child: const Text('Dodaj FitPasos'))
              ],
            ),
            const MySpacer(),
            TextField(
              controller: _pasosIdController,
              decoration: const InputDecoration(
                border: OutlineInputBorder(),
                labelText: 'Unesite ID FitPasosa',
              ),
            ),
            const MySpacer(),
            TextField(
              controller: _korisnikIdController,
              decoration: const InputDecoration(
                border: OutlineInputBorder(),
                labelText: 'Unesite ID Korisnika',
              ),
            ),
            const MySpacer(),
            Row(children: [
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
            const MySpacer(),
            Row(
              children: [
                Checkbox(
                    value: isChecked,
                    onChanged: (value) {
                      setState(() {
                        isChecked = value!;
                      });
                    }),
                const Text("Validan"),
              ],
            ),
            const MySpacer(),
            ElevatedButton(
              onPressed: () async {
                setState(() {
                  isLoading = true;
                });
                try {
                  String? pasosId = _pasosIdController.text.isEmpty
                      ? null
                      : _pasosIdController.text;
                  String? korisnikId = _korisnikIdController.text.isEmpty
                      ? null
                      : _korisnikIdController.text;

                  var pretraga = await fitPasosProvider?.get({
                    "pasosId": pasosId,
                    "korisnikId": korisnikId,
                    "datumIzdavanja": date,
                    "isValid": isChecked
                  });

                  setState(() {
                    fitPasos = pretraga!;
                    isLoading = false;
                  });
                } catch (e) {
                  if (kDebugMode) {
                    print(e);
                  }
                }
              },
              child: const Text('Pretrazi FitPasos'),
            ),
            Expanded(
              child: isLoading
                  ? const Center(
                      child: CircularProgressIndicator(),
                    )
                  : fitPasos.isEmpty
                      ? const Center(
                          child: Text('Učitavanje...'),
                        )
                      : ListView.builder(
                          itemCount: fitPasos.length,
                          itemBuilder: ((context, index) {
                            return VisitRow(
                                nazivnekretnine:
                                    fitPasos[index].pasosId.toString(),
                                datumPosjete: fitPasos[index].datumIzdavanja,
                                vrijemePosjete:
                                    fitPasos[index].korisnik?.korsnikIme,
                                posjeta: Posjeta(),
                                onClicked: () {
                                  setState(() {
                                    fitPasos.removeAt(index);
                                  });
                                },
                                id: fitPasos[index].pasosId);
                          }),
                        ),
            ),
          ],
        ),
      ),
    );
  }
}
