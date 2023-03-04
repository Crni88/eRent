import 'package:flutter/material.dart';
import 'package:myapp/components/button.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/model/nekretnina_tagovi.dart';
import 'package:myapp/providers/nekretnina_provider.dart';
import 'package:myapp/providers/nekretnina_tagovi_provider.dart';
import 'package:myapp/providers/rejting_provider.dart';
import 'package:myapp/providers/user_provider.dart';
import 'package:myapp/screens/poruke.dart';
import 'package:myapp/screens/posjeta.dart';
import 'package:myapp/screens/rezervacija_screen.dart';
import 'package:myapp/utils/util.dart';
import 'package:shared_preferences/shared_preferences.dart';
import '../../components/StarsWidget.dart';
import '../../components/single_nekretnina_row.dart';
import '../../components/spacer.dart';
import '../../components/top_bar.dart';
import '../../providers/nekretnine_provider.dart';
import '../nekretnine/nekretnine_screen.dart';

class SingleNekretninaScreen extends StatefulWidget {
  static const String routeName = "/nekretnina_{id}";

  final int? arguments;

  const SingleNekretninaScreen({super.key, required this.arguments});

  @override
  State<SingleNekretninaScreen> createState() =>
      _SingleNekretninaScreenState(this.arguments);
}

class _SingleNekretninaScreenState extends State<SingleNekretninaScreen> {
  Nekretnina nekretnina = Nekretnina();
  Korisnik? korisnik = Korisnik();
  Korisnik korisnikNekretnina = Korisnik();
  NekretninaTagovi nekretninaTagovi = NekretninaTagovi();
  NekretninaProvider? nekretninaProvider = NekretninaProvider();
  NekretninaTagoviProvider? nekretninaTagoviProvider =
      NekretninaTagoviProvider();
  UserProvider? korisnikProvider = UserProvider();
  RejtingProvider rejtingProvider = RejtingProvider();
  int? arguments;
  String averageAge = "";
  double _rating = 0;
  bool isVisible = false;
  final TextEditingController _komentarController = TextEditingController();
  NekretnineProvider? _nekretnineProvider = NekretnineProvider();
  List<Nekretnina> data = [];

  _SingleNekretninaScreenState(this.arguments);

  @override
  void initState() {
    super.initState();
    arguments = widget.arguments;
    nekretnina = Nekretnina();
    korisnik = Korisnik();
    _nekretnineProvider = NekretnineProvider();
    loadData();
    loadNekretnine();
  }

  Future loadData() async {
    var temp = await nekretninaProvider?.getById(arguments!);
    var temp2 = await nekretninaTagoviProvider?.getById(arguments!);
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? id = prefs.getString('korisnikId');
    var temp3 = await korisnikProvider?.getById(int.parse(id!));
    setState(() {
      nekretnina = temp!;
      nekretninaTagovi = temp2!;
      korisnik = temp3!;
    });
    var avg = await getAvgRejting(nekretnina.korisnikNekretnina);
    var temp4 = await korisnikProvider?.getById(nekretnina.korisnikNekretnina!);
    setState(() {
      korisnikNekretnina = temp4!;
      averageAge = avg;
    });
    if (korisnik?.korisnikId == korisnikNekretnina.korisnikId) {
      setState(() {
        isVisible = true;
      });
    }
  }

  void loadNekretnine() async {
    var tempData = await _nekretnineProvider?.getRecommend(arguments!);
    setState(() {
      data = tempData!;
    });
  }

  Future<String> getAvgRejting(int? id) async {
    var searchObject = {
      "KorisnikPrim": id,
    };
    var temp4 = await rejtingProvider.get(searchObject);
    final int? totalRejting =
        temp4.map((person) => person.rejting1).reduce((a, b) => a! + b!);
    double averageAge = totalRejting! / temp4.length;
    return averageAge.toStringAsFixed(2);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: SingleChildScrollView(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            TopBar(
              context: context,
            ),
            _buildSingleNekretnina(
                korisnikNekretnina,
                nekretnina,
                nekretninaTagovi,
                korisnik,
                averageAge,
                rejtingProvider,
                isVisible,
                data,
                context),
            Container(
              width: 500,
              height: isVisible ? 130 : 400,
              padding: const EdgeInsets.all(20),
              color: const Color.fromRGBO(220, 220, 220, 0.5),
              child: Column(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  _buildRecenzijaBlock(averageAge, korisnikNekretnina, context),
                  Visibility(
                      visible:
                          !isVisible, // if true, show the button, if false, hide
                      child: Column(
                        children: [
                          const MySpacer(),
                          StarRating(
                            starCount: 5,
                            color: Colors.yellow,
                            onRatingUpdate: (rating) {
                              setState(() {
                                _rating = rating;
                              });
                            },
                          ),
                          DecoratedBox(
                            decoration: BoxDecoration(
                              border: Border.all(color: Colors.grey),
                              borderRadius: BorderRadius.circular(5.0),
                              color: Colors.white, // Set the color to white
                            ),
                            child: TextField(
                              controller: _komentarController,
                              keyboardType: TextInputType.multiline,
                              maxLines: 5,
                              textAlignVertical: TextAlignVertical.top,
                              decoration: const InputDecoration(
                                border: InputBorder.none,
                                hintText: 'Enter your text here',
                                contentPadding: EdgeInsets.symmetric(
                                    horizontal: 10.0, vertical: 10.0),
                              ),
                            ),
                          ),
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
                                  var search = {
                                    "korisnikPrim":
                                        nekretnina.korisnikNekretnina,
                                    "korisnikSec": korisnik?.korisnikId,
                                    "nekretninaRejting":
                                        nekretnina.nekretninaId,
                                    "rejting1": _rating,
                                    "komentar": _komentarController.text
                                  };
                                  var temp =
                                      await rejtingProvider.insert(search);
                                  showDialog(
                                      context: context,
                                      builder: (context) {
                                        Future.delayed(
                                            const Duration(seconds: 5), () {
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
                                      builder: (BuildContext context) =>
                                          AlertDialog(
                                            title: const Text("Error"),
                                            content: Text(e.toString()),
                                            actions: [
                                              TextButton(
                                                child: const Text("Ok"),
                                                onPressed: () =>
                                                    Navigator.pop(context),
                                              )
                                            ],
                                          ));
                                }
                              },
                              child: const Center(
                                  child: MyText("Ostavi recenziju", true)),
                            ),
                          ),
                        ],
                      )),
                ],
              ),
            ),
          ],
        ),
      )),
    );
  }
}

Widget _buildSingleNekretnina(
  Korisnik? korisnikNekretnina,
  Nekretnina nekretnina,
  NekretninaTagovi nekretninaTagovi,
  Korisnik? korisnik,
  String averageAge,
  RejtingProvider rejtingProvider,
  bool isVisible,
  List<Nekretnina> data,
  BuildContext context,
) {
  if (nekretnina.nazivNekretnine == null) {
    return SizedBox(
      height: MediaQuery.of(context).size.height -
          350, // adjust the height as needed
      child: const Center(
        child: CircularProgressIndicator(),
      ),
    );
  }
  return Column(children: [
    SizedBox(
      height: 300,
      child: imageFromBase64String(nekretnina.slika!), //slika
    ),
    Container(
      alignment: Alignment.centerLeft,
      padding: const EdgeInsets.all(20),
      child: Column(
          mainAxisAlignment: MainAxisAlignment.start,
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            MyTitle(nekretnina.nazivNekretnine!),
            const MySpacer(),
            //TODO Add Tip Nekretnine
            const SingleNekretinaRow("Tip nekretnine", "Tip", true),
            SingleNekretinaRow(
                "Broj kvadrata", "${nekretnina.brojkvadrata}", false),
            SingleNekretinaRow("Broj soba", "${nekretnina.brojSoba}", true),
            SingleNekretinaRow("Cijena", "${nekretnina.cijena} KM", false),
            const MySpacer(),
            const MyTitle("Detalji nekretnine"),
            _buildNekretnineChipList(nekretninaTagovi),
            //const MySpacer(),
            const MyTitle("Detaljan opis nekretnine"),
            if (nekretnina.opis != null)
              MyText(nekretnina.opis!, false)
            else
              const MyText("Nema detaljnog opisa nekretnine", false),
            const MySpacer(),
            const MyTitle("Želite li vidjeti ovu nekretninu?"),
            const MySpacer(),
            MyButton("Zakaži posjetu", PosjetaScreen(nekretnina, korisnik!)),
            const MySpacer(),
            const MyTitle("Odlučio/a si se za ovu nekretninu?"),
            const MySpacer(),
            MyButton("Rezerviraj", RezervacijaScreen(nekretnina, korisnik)),
            const MySpacer(),
            const MyTitle("Informacije o vlasniku nekretnine:"),
            _korisnikDetails(korisnikNekretnina!, korisnik, averageAge),
            const MySpacer(),
            const MyTitle("Također Vas možda zanima:"),
            SizedBox(
              height: 300, // adjust the height as needed
              child: GridView(
                gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
                  crossAxisCount: 1,
                  childAspectRatio: 5 / 6,
                  mainAxisSpacing: 5,
                ),
                scrollDirection: Axis.horizontal,
                children: _buildNekretnineCardList(data, context),
              ),
            ),
            const MySpacer(),
            MyTitle(isVisible ? "Vaši podaci" : "Ostavi recenziju"),
          ]),
    )
  ]);
}

Widget _korisnikDetails(
    Korisnik? korisnikNekretnina, Korisnik korisnik, String averageAge) {
  if (korisnikNekretnina?.korisnikId == null) {
    return const CircularProgressIndicator();
  } else {
    return Container(
        width: 500,
        height: 200,
        padding: const EdgeInsets.all(20),
        color: const Color.fromRGBO(220, 220, 220,
            0.5), // set the background color to semi-transparent red
        child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            mainAxisAlignment: MainAxisAlignment.spaceBetween,
            children: [
              MyText(
                  "${korisnikNekretnina?.korsnikIme} ${korisnikNekretnina?.korisnikPrezime}",
                  true),
              MyText("${korisnikNekretnina?.email} ", false),
              MyText("Rejting $averageAge/5", true),
              const MySpacer(),
              MyButton(
                  "Posalji poruku",
                  chatpage(
                    email: '${korisnik.email}',
                  ))
            ]));
  }
}

Widget _buildNekretnineChipList(NekretninaTagovi nekretninaTagovi) {
  if (nekretninaTagovi.tags == null) {
    return const CircularProgressIndicator();
  }
  return SizedBox(
    height: 150,
    child: GridView(
        gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
          crossAxisCount: 3,
          childAspectRatio: 4 / 2,
          mainAxisSpacing: 5,
        ),
        children: [
          for (var tag in nekretninaTagovi.tags!)
            Chip(
              label: Text(tag['tagName']),
              backgroundColor: Colors.grey[200],
            )
        ]),
  );
}

Widget _buildRecenzijaBlock(
    String averageAge, Korisnik korisnik, BuildContext context) {
  return Row(
    mainAxisAlignment: MainAxisAlignment.spaceBetween,
    children: [
      Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            MyText("${korisnik.korsnikIme} ${korisnik.korisnikPrezime}", true),
            MyText("${korisnik.email} ", false),
            MyText("Rejting $averageAge/5", true),
          ])
    ],
  );
}

List<Widget> _buildNekretnineCardList(data, context) {
  if (data.isEmpty) {
    return [
      Column(
        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
        crossAxisAlignment: CrossAxisAlignment.center,
        children: const <Widget>[
          CircularProgressIndicator(),
          Text("Loading..."),
        ],
      )
    ];
  }

  List<Widget> list = data
      .map(
        (x) => GestureDetector(
            onTap: () => {
                  Navigator.push(
                    context,
                    MaterialPageRoute(
                        builder: (context) =>
                            SingleNekretninaScreen(arguments: x.nekretninaId)),
                  )
                },
            child: Container(
              height: 250,
              color: x.izdvojena!
                  ? const Color(0xAAF4D06F)
                  : const Color(0xAA9DD9D2),
              padding: const EdgeInsets.all(20),
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  SizedBox(
                      height: 125,
                      width: 125,
                      child: imageFromBase64String(x.slika!)),
                  Row(
                    children: [
                      Column(
                        mainAxisAlignment: MainAxisAlignment.spaceAround,
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(x.nazivNekretnine ?? "",
                              style: const TextStyle(
                                  color: Colors.black,
                                  fontSize: 22,
                                  fontWeight: FontWeight.bold)),
                          Text(x.grad ?? "",
                              style: const TextStyle(
                                  color: Colors.black, fontSize: 16)),
                          SizedBox(
                            width: 150,
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text("Broj soba ${x.brojSoba.toString()}"),
                                Text("${x.cijena.toString()}KM",
                                    style: const TextStyle(
                                        color: Colors.redAccent,
                                        fontSize: 16,
                                        fontWeight: FontWeight.bold))
                              ],
                            ),
                          )
                        ],
                      ),
                    ],
                  ),
                ],
              ),
            )),
      )
      .cast<Widget>()
      .toList();
  return list;
}
