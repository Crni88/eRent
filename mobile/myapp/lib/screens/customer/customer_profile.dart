import 'package:flutter/src/widgets/framework.dart';
import 'package:flutter/src/widgets/placeholder.dart';
import 'package:flutter/material.dart';
import 'package:myapp/components/bottom_menu.dart';
import 'package:myapp/components/mytext.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/providers/user_provider.dart';

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
    // TODO: implement initState
    super.initState();
    loadData();
  }

  loadData() async {
    var temp = await userProvider.getById(2016);
    setState(() {
      korisnik = temp;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: Column(children: [
          TopBar(context: context),
          const MyTitle("Profil"),
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
          ),
        ]),
      ),
    );
  }
}
