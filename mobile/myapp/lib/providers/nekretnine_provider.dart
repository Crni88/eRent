import 'dart:convert';
import 'dart:io';
import 'package:flutter/material.dart';
import 'package:http/io_client.dart';
import 'package:myapp/model/nekretnina.dart';

class NekretnineProvider with ChangeNotifier {
  HttpClient client = HttpClient();
  IOClient? http;
  NekretnineProvider() {
    client.badCertificateCallback = (cert, host, port) => true;
    http = IOClient(client);
  }

  Future<List<Nekretnina>> get(dynamic searchObject) async {
    var url = Uri.parse("https://10.0.2.2:7007/Nekretnine");

    String username = "admin";
    String password = "test";

    String basicAuth =
        "Basic ${base64Encode(utf8.encode('$username:$password'))}";

    var headers = {
      "Content-Type": "application/json",
      "Authorization": basicAuth
    };

    var response = await http!.get(url, headers: headers);
    if (response.statusCode < 400) {
      var data = jsonDecode(response.body);
      List<Nekretnina> list =
          data.map((x) => Nekretnina.fromJson(x)).cast<Nekretnina>().toList();
      return list;
    } else {
      throw Exception("User not allowed!");
    }
  }
}
