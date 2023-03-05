import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/tagovi/Korisnik/korisnik_tagovi.dart';
import 'package:myapp/providers/korisnik_tagovi_provider.dart';
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

  @override
  void initState() {
    super.initState();
    loadData();
  }

  void loadData() async {
    var search = {"KorisnikId": 2016};
    var temp2 = await korisnikTagoviProvider.get(search);
    setState(() {
      korisnikTags = temp2;
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
                              "KorisnikId": 2016,
                              "TagId": element.tagId,
                              "IsActive": element.isActive
                            };
                            await korisnikTagoviProvider.update(
                                element.ktId!, update);
                          });
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
    // if (nekretninaTagovi.tags == null) {
    //   return const CircularProgressIndicator();
    // }
    return SizedBox(
      height: 150,
      child: GridView(
          gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
            crossAxisCount: 3,
            childAspectRatio: 4 / 2,
            mainAxisSpacing: 5,
          ),
          children: [
            for (var tag in nekretninaTagovi)
              if (tag.tagId == 1004)
                GestureDetector(
                    onTap: () {
                      setState(() {
                        tag.isActive = !tag.isActive!;
                      });
                    },
                    child: Chip(
                      label: const Text("Tiho naselje"),
                      backgroundColor:
                          tag.isActive! ? Colors.blue : Colors.grey,
                    ))
              else if (tag.tagId == 1005)
                GestureDetector(
                    onTap: () {
                      setState(() {
                        tag.isActive = !tag.isActive!;
                      });
                    },
                    child: Chip(
                      label: const Text("Miran"),
                      backgroundColor:
                          tag.isActive! ? Colors.blue : Colors.grey,
                    ))
              else if (tag.tagId == 1006)
                GestureDetector(
                    onTap: () {
                      setState(() {
                        tag.isActive = !tag.isActive!;
                      });
                    },
                    child: Chip(
                      label: const Text("No smoking"),
                      backgroundColor:
                          tag.isActive! ? Colors.blue : Colors.grey,
                    ))
              else if (tag.tagId == 1007)
                GestureDetector(
                    onTap: () {
                      setState(() {
                        tag.isActive = !tag.isActive!;
                      });
                    },
                    child: Chip(
                      label: const Text("Osvijetljen"),
                      backgroundColor:
                          tag.isActive! ? Colors.blue : Colors.grey,
                    ))
              else if (tag.tagId == 1008)
                GestureDetector(
                    onTap: () {
                      setState(() {
                        tag.isActive = !tag.isActive!;
                      });
                    },
                    child: Chip(
                      label: const Text("Pet Friendly"),
                      backgroundColor:
                          tag.isActive! ? Colors.blue : Colors.grey,
                    ))
          ]),
    );
  }
}
