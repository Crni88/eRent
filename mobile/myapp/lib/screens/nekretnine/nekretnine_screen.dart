import 'dart:typed_data';

import 'package:flutter/material.dart';
import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/providers/nekretnine_provider.dart';
import 'package:provider/provider.dart';

import '../../utils/util.dart';

class NekretnineListScreen extends StatefulWidget {
  static const String routeName = "/nekretnine";
  const NekretnineListScreen({super.key});

  @override
  State<NekretnineListScreen> createState() => _NekretnineListScreenState();
}

class _NekretnineListScreenState extends State<NekretnineListScreen> {
  NekretnineProvider? _nekretnineProvider;
  List<Nekretnina> data = [];
  @override
  void initState() {
    super.initState();
    _nekretnineProvider = context.read<NekretnineProvider>();
    loadData();
  }

  Future loadData() async {
    var tempData = await _nekretnineProvider?.get(null);
    setState(() {
      data = tempData!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: SafeArea(
            child: SingleChildScrollView(
      child: Column(
        children: [
          Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: const [Text("data"), Text("data")]),
          _buildHeader(),
          const TextField(
            decoration: InputDecoration(
              hintText: "Search",
              hintStyle: TextStyle(fontSize: 20.0, color: Colors.blueAccent),
            ),
          ),
          const SizedBox(height: 10),
          SizedBox(
            height: 650,
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
      ),
    )));
  }

  Widget _buildHeader() {
    return Container(
      padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 10),
      child: const Text(
        "Nekretnine",
        style: TextStyle(
            color: Colors.greenAccent,
            fontSize: 44,
            fontWeight: FontWeight.bold),
      ),
    );
  }

  List<Widget> _buildNekretnineCardList() {
    if (data.isEmpty) {
      return [
        Column(
          mainAxisAlignment: MainAxisAlignment.spaceEvenly,
          children: const <Widget>[
            CircularProgressIndicator(),
            Text("Loading"),
          ],
        )
      ];
    }
    List<Widget> list = data
        .map((x) => Container(
              height: 250,
              color: x.izdvojena
                  ? const Color(0xAAF4D06F)
                  : const Color(0xAA9DD9D2),
              padding: const EdgeInsets.symmetric(horizontal: 10),
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.center,
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                children: [
                  SizedBox(
                      height: 200,
                      width: 200,
                      child: imageFromBase64String(x.slika!)),
                  Row(
                    children: [
                      Column(
                        mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(x.nazivNekretnine ?? "",
                              style: const TextStyle(
                                  color: Colors.black,
                                  fontSize: 22,
                                  fontWeight: FontWeight.bold)),
                          Text(x.grad ?? "",
                              style: const TextStyle(
                                  color: Colors.black, fontSize: 16)),
                          SizedBox(
                            width: 150,
                            child: Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Text("Broj soba ${x.brojSoba.toString()}"),
                                Text("${x.cijena.toString()}KM")
                              ],
                            ),
                          )
                        ],
                      ),
                    ],
                  ),
                ],
              ),
            ))
        .cast<Widget>()
        .toList();
    return list;
  }
}
