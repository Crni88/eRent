import 'package:flutter/foundation.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/providers/nekretnine_provider.dart';
import 'package:provider/provider.dart';
import 'package:shared_preferences/shared_preferences.dart';
import '../../components/top_bar.dart';
import '../../providers/user_provider.dart';
import '../../utils/util.dart';
import '../single_nekretnina/single_nekretnina_screen.dart';

class NekretnineListScreen extends StatefulWidget {
  static const String routeName = "/nekretnine";
  const NekretnineListScreen({super.key});

  @override
  State<NekretnineListScreen> createState() => _NekretnineListScreenState();
}

class _NekretnineListScreenState extends State<NekretnineListScreen> {
  NekretnineProvider? _nekretnineProvider;
  final UserProvider _userProvider = UserProvider();
  final TextEditingController _brojSobaController = TextEditingController();
  final TextEditingController _nameFTSController = TextEditingController();
  final TextEditingController _cijenaMinController = TextEditingController();
  final TextEditingController _cijenaMaxController = TextEditingController();
  bool _expanded = false;

  List<Nekretnina> data = [];

  @override
  void setState(fn) {
    if (mounted) {
      super.setState(fn);
    }
  }

  @override
  void initState() {
    super.initState();
    _nekretnineProvider = context.read<NekretnineProvider>();
    registerUserToken();
    loadData();
  }

  Future loadData() async {
    var search = {"IsActive": true};
    var tempData = await _nekretnineProvider?.get(search);
    setState(() {
      data = tempData!;
    });
    filterResults();
    startAlgorithm(data);
  }

  Future<void> registerUserToken() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? id = prefs.getString('korisnikId');
    String? token = prefs.getString('fcmToken');
    String? imePrezime = prefs.getString('korisnikImePrezime');
    List<String>? nameParts = imePrezime?.split(" ");
    String firstName = nameParts![0];
    String lastName = nameParts[1];
    var userUpdate = {
      'fcmDeviceToken': token,
      'korsnikIme': firstName,
      'korisnikPrezime': lastName,
      'uloga': 'Korisnik',
      'isActive': true,
    };
    _userProvider?.update(int.parse(id!), userUpdate);
  }

  void filterResults() {
    List<Nekretnina> data2 = [];
    for (var element in data) {
      if (element.izdvojena == true) {
        data2.insert(0, element);
        //data.remove(element);
      }
    }
    data.removeWhere((element) => data2.contains(element));
    data2.addAll(data.reversed);
    setState(() {
      data = data2;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
            child: SingleChildScrollView(
                child: Column(
      children: [
        TopBar(context: context),
        Column(children: [
          _expanded
              ? Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                      Expanded(
                        child: TextField(
                          controller: _nameFTSController,
                          decoration: const InputDecoration(
                              labelText: "Name",
                              hintStyle: TextStyle(
                                  fontSize: 20.0, fontWeight: FontWeight.bold)),
                        ),
                      ),
                      const SizedBox(
                        width: 50,
                      ),
                      Expanded(
                        child: TextField(
                          controller: _brojSobaController,
                          decoration: const InputDecoration(
                              labelText: "No. of rooms",
                              hintStyle: TextStyle(
                                  fontSize: 20.0, fontWeight: FontWeight.bold)),
                          keyboardType: TextInputType.number,
                          inputFormatters: <TextInputFormatter>[
                            FilteringTextInputFormatter.digitsOnly
                          ],
                        ),
                      ),
                    ])
              : Container(),
          _expanded
              ? Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                      Expanded(
                        child: TextField(
                          controller: _cijenaMinController,
                          decoration: const InputDecoration(
                              labelText: "Min. price",
                              hintStyle: TextStyle(
                                  fontSize: 20.0, fontWeight: FontWeight.bold)),
                          keyboardType: TextInputType.number,
                          inputFormatters: <TextInputFormatter>[
                            FilteringTextInputFormatter.digitsOnly
                          ], // Only numbers can be entered
                        ),
                      ),
                      const SizedBox(
                        width: 50,
                      ),
                      Expanded(
                        child: TextField(
                          controller: _cijenaMaxController,
                          decoration: const InputDecoration(
                              labelText: "Max price",
                              hintStyle: TextStyle(
                                  fontSize: 20.0, fontWeight: FontWeight.bold)),
                          keyboardType: TextInputType.number,
                          inputFormatters: <TextInputFormatter>[
                            FilteringTextInputFormatter.digitsOnly
                          ],
                        ),
                      ),
                    ])
              : Container(),
          _expanded ? const MySpacer() : Container(),
          _expanded
              ? Container(
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
                          "NameFTS": _nameFTSController.text,
                          "CijenaMax": 0,
                          "CijenaMin": 0,
                          "BrojSoba": 0,
                        };
                        if (_cijenaMaxController.text != "") {
                          search["CijenaMax"] =
                              int.parse(_cijenaMaxController.text);
                        }
                        if (_cijenaMinController.text != "") {
                          search["CijenaMin"] =
                              int.parse(_cijenaMinController.text);
                        }
                        if (_brojSobaController.text != "") {
                          search["BrojSoba"] =
                              int.parse(_brojSobaController.text);
                        }
                        if (search != {}) {
                          data = [];
                          var tempData = await _nekretnineProvider?.get(search);
                          setState(() {
                            data = tempData!;
                          });
                        } else {
                          loadData();
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
                    child: const Center(child: MyText("Search", true)),
                  ),
                )
              : Container()
        ]),
        //Button Search
        _expanded
            ? IconButton(
                icon: const Icon(Icons.arrow_drop_up),
                onPressed: () {
                  setState(() {
                    _expanded = false;
                  });
                })
            : IconButton(
                icon: const Icon(Icons.arrow_drop_down),
                onPressed: () {
                  setState(() {
                    _expanded = true;
                  });
                }),
        SizedBox(
          height: MediaQuery.of(context).size.height -
              165, // adjust the height as needed
          child: GridView(
            gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
              crossAxisCount: 1,
              childAspectRatio: 4 / 2,
              mainAxisSpacing: 5,
            ),
            scrollDirection: Axis.vertical,
            children: _buildNekretnineCardList(),
          ),
        ),
      ],
    ))));
  }

  List<Widget> _buildNekretnineCardList() {
    if (data.isEmpty) {
      return [
        const Column(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: <Widget>[
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
                    child: imageFromBase64String(x.slika!),
                  ),
                  const SizedBox(width: 20), // Add horizontal spacing here
                  Expanded(
                    child: Row(
                      children: [
                        Column(
                          mainAxisAlignment: MainAxisAlignment.spaceAround,
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text(
                              x.nazivNekretnine != null &&
                                      x.nazivNekretnine!.length > 18
                                  ? '${x.nazivNekretnine!.substring(0, 18)}...'
                                  : x.nazivNekretnine ?? "",
                              style: const TextStyle(
                                color: Colors.black,
                                fontSize: 22,
                                fontWeight: FontWeight.bold,
                                overflow: TextOverflow.clip,
                              ),
                            ),
                            Text(
                              x.grad ?? "",
                              style: const TextStyle(
                                color: Colors.black,
                                fontSize: 16,
                              ),
                            ),
                            Text(
                              "Broj soba ${x.brojSoba.toString()}",
                            ),
                            Text(
                              "${x.cijena.toString()}KM",
                              style: const TextStyle(
                                color: Colors.redAccent,
                                fontSize: 16,
                                fontWeight: FontWeight.bold,
                              ),
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ],
              ),
            ),
          ),
        )
        .cast<Widget>()
        .toList();
    return list;
  }

  void startAlgorithm(List<Nekretnina> data) async {
    try {
      await _nekretnineProvider?.getRecommend(data[0].nekretninaId!);
    } catch (e) {
      if (kDebugMode) {
        print(e.toString());
      }
    }
  }
}
