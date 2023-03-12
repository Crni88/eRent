import 'dart:convert';

import 'package:myapp/model/nekretnina_tagovi.dart';
import 'package:myapp/providers/base_provider.dart';

class NekretninaTagoviProvider extends BaseProvider<NekretninaTagovi> {
  NekretninaTagoviProvider() : super("NekretnineTagovi");

  @override
  NekretninaTagovi fromJson(data) {
    return NekretninaTagovi.fromJson(data);
  }

  @override
  Future<NekretninaTagovi> getById(int id, [dynamic additionalData]) async {
    var url = Uri.parse(
        "https://10.0.2.2:5192/NekretnineTagovi/TagsByProperty?id=$id");

    Map<String, String> headers = createHeaders();

    var response = await http!.get(url, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      throw Exception("An error occured!");
    }
  }

  @override
  Future<NekretninaTagovi> getByUserId(int id, [dynamic additionalData]) async {
    var url =
        Uri.parse("http://10.0.2.2:5192/KorisnikTagovi/TagsByUser?id=$id");

    Map<String, String> headers = createHeaders();

    var response = await http!.get(url, headers: headers);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      throw Exception("An error occured!");
    }
  }
}
