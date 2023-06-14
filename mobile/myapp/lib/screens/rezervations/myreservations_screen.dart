import 'package:flutter/material.dart';
import 'package:myapp/components/spacer.dart';
import 'package:myapp/components/title.dart';
import 'package:myapp/model/rezervacija.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../components/bottom_menu.dart';
import '../../components/reservation_row.dart';
import '../../components/top_bar.dart';
import '../../providers/rezervacija_provider.dart';

class MyReservationsScreen extends StatefulWidget {
  const MyReservationsScreen({super.key});

  @override
  State<MyReservationsScreen> createState() => _MyReservationsScreenState();
}

class _MyReservationsScreenState extends State<MyReservationsScreen> {
  //Load rezervacije
  List<Rezervacija> rezervacije = [];
  RezervacijaProvider rezervacijaProvider = RezervacijaProvider();

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
    var temp = await rezervacijaProvider.get(search);
    setState(() {
      rezervacije = temp;
    });
  }

  //Bottom bar
  int _selectedIndex = 2;
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
          const MyTitle("Moje rezervacije"),
          const MySpacer(),
          Expanded(
              child: ListView.builder(
                  itemCount: rezervacije.length,
                  itemBuilder: ((context, index) {
                    return ReservationRow(
                      rezervacije[index],
                      id: rezervacije[index].rezervacijaId!,
                      brojTelefona: rezervacije[index].brojTelefona!,
                      datumKraja: rezervacije[index].datumKraja!,
                      datumPocetka: rezervacije[index].datumPocetka!,
                      imePrezime: rezervacije[index].imePrezime!,
                      mjesecnaRezervacija:
                          rezervacije[index].mjesecnaRezervacija!,
                      nazivnekretnine: rezervacije[index].nazivnekretnine!,
                      odobrena: rezervacije[index].mjesecnaRezervacija!,
                      onClick: () {
                        print("Rezervacija odbijena");
                        Navigator.pushReplacement(
                          context,
                          MaterialPageRoute(
                              builder: (context) =>
                                  const MyReservationsScreen()),
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
