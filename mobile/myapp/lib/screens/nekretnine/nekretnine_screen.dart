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
              mainAxisAlignment:
                  MainAxisAlignment.spaceBetween, // set your alignment
              children: const [Text("data"), Text("data")]),
          _buildHeader(),
          const TextField(
            decoration: InputDecoration(
              hintText: "Search",
              hintStyle: TextStyle(fontSize: 20.0, color: Colors.blueAccent),
            ),
          ),
          SizedBox(
            height: 200,
            child: GridView(
              gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
                crossAxisCount: 1,
                childAspectRatio: 4 / 3,
                crossAxisSpacing: 20,
                mainAxisSpacing: 30,
              ),
              scrollDirection: Axis.horizontal,
              children: _buildNekretnineCardList(),
            ),
          )
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
      return [const Text("Loading...")];
    }
    List<Widget> list = data
        .map((x) => SizedBox(
              height: 200,
              width: 200,
              child: Row(
                children: [
                  imageFromBase64String(x.slika!),
                  Column(
                    children: [
                      Text(x.nazivNekretnine ?? "Wrong property name"),
                      Text(x.grad ?? ""),
                      Row(
                        children: [
                          Text("Broj soba ${x.brojSoba.toString()}"),
                          Text(x.cijena.toString())
                        ],
                      )
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
