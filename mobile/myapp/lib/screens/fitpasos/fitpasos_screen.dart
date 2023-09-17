import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/FitPasosModel.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/providers/fitpasos_provider.dart';
import 'package:myapp/providers/user_provider.dart';
import 'package:myapp/screens/fitpasos/addFitPasos_screen.dart';

class FitPasosScreen extends StatefulWidget {
  const FitPasosScreen({super.key});

  @override
  State<FitPasosScreen> createState() => _FitPasosScreenState();
}

class _FitPasosScreenState extends State<FitPasosScreen> {
  FitPasosProvider _fitPasosProvider = FitPasosProvider();
  UserProvider _userProvider = UserProvider();
  List<FitPasos> fitPasos = [];
  List<int> Korisnik_Ids = [];
  bool isValid = false;
  bool isLoading = true;
  TextEditingController _controller = TextEditingController();
  DateTime _selectedDate = DateTime.now();
  @override
  void initState() {
    super.initState();
    loadData();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
      child: Center(
          child: Column(
        children: [
          const MyTitle("FitPasos"),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              const MyText("Dodaj fit Pasos", true),
              ElevatedButton(
                  onPressed: () => {
                        Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) =>
                                    const AddFitPasosScreen()))
                      },
                  child: const MyText("Dodaj", true))
            ],
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              const MyText("Korisnik Id", false),
              DropdownButton<int>(
                  hint: const MyText("Korisnik Id", false),
                  value: int.tryParse(_controller.text),
                  items: Korisnik_Ids.map((int value) => DropdownMenuItem<int>(
                      value: value, child: Text(value.toString()))).toList(),
                  onChanged: (int? value) {
                    setState(() {
                      _controller.text = value.toString();
                    });
                  }),
            ],
          ),
          const MySpacer(),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              Checkbox(
                  value: isValid,
                  onChanged: (bool? value) async {
                    setState(() {
                      isValid = !isValid;
                      //isLoading = true;
                    });
                  }),
              const MyText("Da li je Validan?", false),
            ],
          ),
          const MySpacer(),
          ElevatedButton(
            onPressed: () async {
              var temp = pickDate(context);
              setState(() {
                _selectedDate = temp as DateTime;
              });
            },
            child: const Text("Odaberi datum izdavanja"),
          ),
          const MySpacer(),
          ElevatedButton(
            onPressed: () async {
              try {
                setState(() {
                  isLoading = true;
                });

                String? tempId = _controller.text.isEmpty
                    ? null
                    : _controller.text.toString();

                var search = {
                  "KorisnikId": int.parse(tempId!),
                  "isValid": isValid,
                  "DatumIzdavanja": _selectedDate
                };
                var temp = await _fitPasosProvider.get(search);
                setState(() {
                  fitPasos = temp;
                });
              } catch (e) {
                print(e);
              } finally {
                setState(() {
                  isLoading = false;
                });
              }
            },
            child: const MyText("Pretrazi FitPasos", false),
          ),
          const MySpacer(),
          Expanded(
            child: isLoading
                ? const Center(child: CircularProgressIndicator())
                : ListView.builder(
                    itemCount: fitPasos.length,
                    itemBuilder: (BuildContext context, int index) {
                      return VisitsRow(fitPasos[index]);
                    },
                  ),
          ),
        ],
      )),
    ));
  }

  Future<DateTime?> pickDate(BuildContext context) {
    return showDatePicker(
        context: context,
        initialDate: DateTime.now(),
        firstDate: DateTime(2020),
        lastDate: DateTime.now());
  }

  Widget VisitsRow(fitpasos) {
    return Card(
      child: ListTile(
          leading: const Icon(Icons.card_membership),
          title: Text("Pasos Id ${fitpasos.pasosId}"),
          subtitle: Text("Korisnik Id ${fitpasos.korisnikId}"),
          trailing: Text(
              "Datum Izdavanja ${fitpasos.datumIzdavanja.toString().substring(0, 10)}")),
    );
  }

  void loadData() async {
    var temp = await _fitPasosProvider.get();
    setState(() {
      fitPasos = temp;
      isLoading = false;
    });
    loadKorisnici();
  }

  void loadKorisnici() async {
    var temp = await _userProvider.get();
    for (var item in temp) {
      Korisnik_Ids.add(item.korisnikId!);
    }
  }
}
