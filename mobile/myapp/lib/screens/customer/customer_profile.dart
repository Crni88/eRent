import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter/src/widgets/placeholder.dart';
import 'package:flutter/material.dart';
import 'package:myapp/components/bottom_menu.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/providers/user_provider.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../components/title.dart';

class CustomerProfileScreen extends StatefulWidget {
  const CustomerProfileScreen({super.key});

  @override
  State<CustomerProfileScreen> createState() => _CustomerProfileScreenState();
}

class _CustomerProfileScreenState extends State<CustomerProfileScreen> {
  Korisnik korisnik = Korisnik();
  UserProvider userProvider = UserProvider();
  @override
  void initState() {
    super.initState();
    loadData();
  }

  loadData() async {
    SharedPreferences prefs = await SharedPreferences.getInstance();
    String? id = prefs.getString('korisnikId');
    var temp = await userProvider.getById(int.parse(id!));
    setState(() {
      korisnik = temp;
    });
  }

  int _selectedIndex = 0;

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(children: [
          TopBar(context: context),
          const MyTitle("Profil"),
          Expanded(
              child: Column(
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  const MyText("Ime: ", true),
                  korisnik.korsnikIme != null
                      ? Text(korisnik.korsnikIme!)
                      : const Text("Nema podataka"),
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  const MyText("Prezime: ", true),
                  korisnik.korisnikPrezime != null
                      ? Text(korisnik.korisnikPrezime!)
                      : const Text("Nema podataka"),
                ],
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  const MyText("Email: ", true),
                  korisnik.email != null
                      ? Text(korisnik.email!)
                      : const Text("Nema podataka"),
                ],
              )
            ],
          )),
          MyBottomBar(
            currentIndex: _selectedIndex,
            onTap: _onItemTapped,
          ),
        ]),
      ),
    );
  }
}
