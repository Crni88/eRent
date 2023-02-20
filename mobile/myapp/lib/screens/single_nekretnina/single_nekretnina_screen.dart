import 'package:flutter/material.dart';
import 'package:myapp/components/button.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/model/nekretnina_tagovi.dart';
import 'package:myapp/providers/nekretnina_provider.dart';
import 'package:myapp/providers/nekretnina_tagovi_provider.dart';
import 'package:myapp/utils/util.dart';
import '../../components/single_nekretnina_row.dart';
import '../../components/spacer.dart';
import '../../components/top_bar.dart';

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
  NekretninaTagovi nekretninaTagovi = NekretninaTagovi();
  NekretninaProvider? nekretninaProvider = NekretninaProvider();
  NekretninaTagoviProvider? nekretninaTagoviProvider =
      NekretninaTagoviProvider();
  int? arguments;

  _SingleNekretninaScreenState(this.arguments);

  @override
  void initState() {
    super.initState();
    arguments = widget.arguments;
    nekretnina = Nekretnina();
    loadData();
  }

  Future loadData() async {
    var temp = await nekretninaProvider?.getById(arguments!);
    var temp2 = await nekretninaTagoviProvider?.getById(arguments!);
    setState(() {
      nekretnina = temp!;
      nekretninaTagovi = temp2!;
    });
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
            _buildSingleNekretnina(nekretnina, nekretninaTagovi),
          ],
        ),
      )),
    );
  }
}

Widget _buildSingleNekretnina(
    Nekretnina nekretnina, NekretninaTagovi nekretninaTagovi) {
  if (nekretnina.nazivNekretnine == null) {
    return Column(
      children: const [
        CircularProgressIndicator(),
        Text("Loading..."),
      ],
    );
  }
  return Column(
    children: [
      SizedBox(
        height: 300,
        child: imageFromBase64String(nekretnina.slika!), //slika
      ),
      Container(
        alignment: Alignment.centerLeft,
        padding: const EdgeInsets.all(20),
        child: Column(
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
            const MyButton("Zakaži posjetu", onPressed: null),
            const MySpacer(),
            const MyTitle("Odlučio/a si se za ovu nekretninu?"),
            const MySpacer(),
            const MyButton("Rezervisi!", onPressed: null),
            const MySpacer(),
            const MyTitle("Informacije o vlasniku nekretnine:"),
          ],
        ),
      ),
    ],
  );
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
