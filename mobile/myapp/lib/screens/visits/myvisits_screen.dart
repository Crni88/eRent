import 'package:flutter/material.dart';
import 'package:myapp/components/bottom_menu.dart';
import 'package:myapp/model/posjeta.dart';
import 'package:myapp/providers/posjeta_provider.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../components/spacer.dart';
import '../../components/title.dart';
import '../../components/top_bar.dart';
import '../../components/visits_row.dart';

class MyVisitsScreen extends StatefulWidget {
  const MyVisitsScreen({super.key});

  @override
  State<MyVisitsScreen> createState() => _MyVisitsScreenState();
}

class _MyVisitsScreenState extends State<MyVisitsScreen> {
  PosjetaProvider posjetaProvider = PosjetaProvider();
  List<Posjeta> posjete = [];

  @override
  void initState() {
    super.initState();
    loadData();
  }

  void loadData() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? tempId = prefs.getString('korisnikId');
    var search = {
      "KorisnikId": int.parse(tempId!),
      "Otkazana": false,
    };
    var temp = await posjetaProvider.get(search);
    setState(() {
      posjete = temp;
    });
  }

  //Bottom bar
  int _selectedIndex = 3;
  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Column(
        children: [
          TopBar(context: context),
          const MyTitle("Moje Posjete"),
          const MySpacer(),
          Expanded(
              child: ListView.builder(
                  itemCount: posjete.length,
                  itemBuilder: ((context, index) {
                    return VisitRow(
                      posjeta: posjete[index],
                      id: posjete[index].posjetaId!,
                      datumPosjete: posjete[index].datumPosjete!,
                      nazivnekretnine: posjete[index].nazivNekretnine!,
                      vrijemePosjete: posjete[index].vrijemePosjete!,
                      onClicked: () {
                        print("Rezervacija odbijena");
                        Navigator.pushReplacement(
                          context,
                          MaterialPageRoute(
                              builder: (context) => const MyVisitsScreen()),
                        );
                      },
                    );
                  }))),
          MyBottomBar(
            currentIndex: _selectedIndex,
            onTap: _onItemTapped,
          ),
        ],
      )),
    );
  }
}
