import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/nekretnina_tagovi.dart';
import 'package:myapp/model/tagovi/tags.dart';
import 'package:myapp/providers/tags_provider.dart';
import '../../components/mytext.dart';
import '../../providers/nekretnina_tagovi_provider.dart';
import '../nekretnine/nekretnine_screen.dart';

class KorisnikTagoviScreen extends StatefulWidget {
  const KorisnikTagoviScreen({super.key});

  @override
  State<KorisnikTagoviScreen> createState() => _KorisnikTagoviScreenState();
}

class _KorisnikTagoviScreenState extends State<KorisnikTagoviScreen> {
  List<Tags> allTags = [];
  NekretninaTagovi korisnikTags = NekretninaTagovi();

  TagsProvider tagsProvider = TagsProvider();
  NekretninaTagoviProvider nekretninaTagoviProvider =
      NekretninaTagoviProvider();
  @override
  void initState() {
    super.initState();
    loadData();
  }

  List<dynamic> tags = [];

  void loadData() async {
    var temp = await tagsProvider.get();
    var temp2 = await nekretninaTagoviProvider.getByUserId(2016);
    setState(() {
      allTags = temp;
      korisnikTags = temp2;
      tags = korisnikTags.tags!;
    });
    if (allTags.isNotEmpty && tags.isNotEmpty) {
      showTags();
    }
  }

  void removeFromCustomerList(tag) {
    setState(() {
      tags.remove(tag);
    });
  }

  void addToAllChipList(tag) {
    Tags tag2 = Tags();
    tag2.tagName = tag['tagName'];
    tag2.tagId = tag['tagId'];
    setState(() {
      allTags.add(tag2);
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
                  const MyTitle("Vasi tagovi"),
                  Expanded(
                    child: _buildCustomerChips(
                        korisnikTags, removeFromCustomerList, addToAllChipList),
                  ),
                  const Divider(
                    height: 1,
                    color: Colors.grey,
                  ),
                  const MyTitle("Svi tagovi"),
                  Expanded(
                    child: _buildNekretnineChipList(
                        allTags, removeNekretnineChipList, addToCustomerList),
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
                          var temp2 =
                              await nekretninaTagoviProvider.getByUserId(2016);
                          korisnikTags.tags?.forEach((element) async {
                            await tagsProvider.insertCustomerTags({
                              "korisnikId": 2016,
                              "tagId": element['tagId']
                            });
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

  void showTags() {
    allTags.removeWhere((tag) => tags.any((t) => t['tagName'] == tag.tagName));
  }

  void addToCustomerList(tag) {
    Map tag1 = {
      'tagId': tag.tagId!,
      'tagName': tag.tagName,
    };
    korisnikTags.tags?.add(tag1);
    print(korisnikTags.tags);
  }

  void removeNekretnineChipList(tag) {
    setState(() {
      allTags.remove(tag);
    });
  }
}

Widget _buildNekretnineChipList(
    List<Tags> nekretninaTagovi,
    void Function(dynamic tag) removeNekretnineChipList,
    void Function(dynamic tag) addToCustomerList) {
  if (nekretninaTagovi.isEmpty) {
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
          for (var tag in nekretninaTagovi)
            GestureDetector(
              onTap: () {
                addToCustomerList(tag);
                removeNekretnineChipList(tag);
              },
              child: Chip(
                label: Text(tag.tagName!),
                backgroundColor: Colors.grey[200],
              ),
            )
        ]),
  );
}

Widget _buildCustomerChips(
    NekretninaTagovi nekretninaTagovi,
    void Function(dynamic tag) removeFromCustomerList,
    void Function(dynamic tag) addToAllChipList) {
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
            GestureDetector(
              onTap: () {
                removeFromCustomerList(tag);
                addToAllChipList(tag);
              },
              child: Chip(
                label: Text(tag['tagName']),
                backgroundColor: Colors.grey[200],
              ),
            )
        ]),
  );
}
