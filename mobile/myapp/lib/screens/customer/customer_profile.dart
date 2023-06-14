import 'package:flutter/material.dart';
import 'package:myapp/components/bottom_menu.dart';
import 'package:myapp/components/top_bar.dart';
import 'package:myapp/model/korisnik.dart';
import 'package:myapp/providers/user_provider.dart';
import 'package:shared_preferences/shared_preferences.dart';

import '../../components/title.dart';

class CustomerProfileScreen extends StatefulWidget {
  const CustomerProfileScreen({Key? key}) : super(key: key);

  @override
  _CustomerProfileScreenState createState() => _CustomerProfileScreenState();
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
        child: Column(
          children: [
            TopBar(context: context),
            const MyTitle("Profil"),
            Expanded(
              child: Padding(
                padding: const EdgeInsets.all(16.0),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    ProfileInfoRow(
                      label: "Ime:",
                      value: korisnik.korsnikIme ?? "Nema podataka",
                    ),
                    ProfileInfoRow(
                      label: "Prezime:",
                      value: korisnik.korisnikPrezime ?? "Nema podataka",
                    ),
                    ProfileInfoRow(
                      label: "Email:",
                      value: korisnik.email ?? "Nema podataka",
                    ),
                  ],
                ),
              ),
            ),
            MyBottomBar(
              currentIndex: _selectedIndex,
              onTap: _onItemTapped,
            ),
          ],
        ),
      ),
    );
  }
}

class ProfileInfoRow extends StatelessWidget {
  final String label;
  final String value;

  const ProfileInfoRow({
    super.key,
    required this.label,
    required this.value,
  });

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 8.0),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(
            label,
            style: const TextStyle(
              fontSize: 16.0,
              fontWeight: FontWeight.bold,
            ),
          ),
          Text(
            value,
            style: const TextStyle(fontSize: 16.0),
          ),
        ],
      ),
    );
  }
}
