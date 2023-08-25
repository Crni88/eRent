import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/tagovi/Korisnik/korisnik_tagovi.dart';
import 'package:myapp/providers/korisnik_tagovi_provider.dart';
import 'package:shared_preferences/shared_preferences.dart';
import '../../components/mytext.dart';
import '../nekretnine/nekretnine_screen.dart';

class KorisnikTagoviScreen extends StatefulWidget {
  const KorisnikTagoviScreen({super.key});

  @override
  State<KorisnikTagoviScreen> createState() => _KorisnikTagoviScreenState();
}

class _KorisnikTagoviScreenState extends State<KorisnikTagoviScreen> {
  List<KorisnikTagovi> korisnikTags = [];
  KorisnikTagoviProvider korisnikTagoviProvider = KorisnikTagoviProvider();
  String id = "";
  @override
  void initState() {
    super.initState();
    loadData();
  }

  void loadData() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? tempId = prefs.getString('korisnikId');
    var search = {"KorisnikId": int.parse(tempId!)};
    var temp2 = await korisnikTagoviProvider.get(search);
    setState(() {
      korisnikTags = temp2;
      id = tempId;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Container(
              padding: const EdgeInsets.symmetric(horizontal: 15, vertical: 5),
              child: Column(
                children: [
                  const MySpacer(),
                  const MyTitle("Vaši tagovi"),
                  Expanded(
                    child: _buildCustomerChips(korisnikTags),
                  ),
                  const Divider(
                    height: 1,
                    color: Colors.grey,
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
                          korisnikTags.forEach((element) async {
                            var update = {
                              "KorisnikId": id,
                              "TagId": element.tagId,
                              "IsActive": element.isActive
                            };
                            await korisnikTagoviProvider.update(
                                element.ktId!, update);
                          });
                          Navigator.pop(context);
                          showDialog(
                              context: context,
                              builder: (context) {
                                Future.delayed(
                                    const Duration(seconds: 2), () {});
                                return const AlertDialog(
                                  title: Text('Uspjesno spremljeno!'),
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
                      child: const Center(child: MyText("Spremi", true)),
                    ),
                  ),
                ],
              ))),
    );
  }

  Widget _buildCustomerChips(List<KorisnikTagovi> nekretninaTagovi) {
    return nekretninaTagovi.isEmpty
        ? const Center(
            child: CircularProgressIndicator(), // Circular loader
          )
        : SizedBox(
            height: 150,
            child: GridView.count(
              crossAxisCount: 3,
              childAspectRatio: 4 / 2,
              mainAxisSpacing: 5,
              children: [
                for (var tag in nekretninaTagovi)
                  GestureDetector(
                    onTap: () {
                      setState(() {
                        tag.isActive = !tag.isActive!;
                      });
                    },
                    child: Chip(
                      label: Text(
                        tag.tagId == 1
                            ? "Tiho naselje"
                            : tag.tagId == 2
                                ? "Miran"
                                : tag.tagId == 3
                                    ? "No smoking"
                                    : tag.tagId == 4
                                        ? "Osvijetljen"
                                        : tag.tagId == 5
                                            ? "Pet Friendly"
                                            : "",
                      ),
                      backgroundColor:
                          tag.isActive! ? Colors.blue : Colors.grey,
                    ),
                  ),
              ],
            ),
          );
  }
}
