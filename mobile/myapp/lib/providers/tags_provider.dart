import 'dart:convert';

import 'package:myapp/model/tagovi/tags.dart';
import 'package:myapp/providers/base_provider.dart';

class TagsProvider extends BaseProvider<Tags> {
  TagsProvider() : super("Tags");

  @override
  Tags fromJson(data) {
    return Tags.fromJson(data);
  }

  Future<Tags?> insertCustomerTags(dynamic request) async {
    var url = "https://10.0.2.2:7007/KorisnikTagovi/";
    var uri = Uri.parse(url);

    Map<String, String> headers = createHeaders();
    var jsonRequest = jsonEncode(request);
    var response = await http!.post(uri, headers: headers, body: jsonRequest);

    if (isValidResponseCode(response)) {
      var data = jsonDecode(response.body);
      return fromJson(data);
    } else {
      return null;
    }
  }
}
