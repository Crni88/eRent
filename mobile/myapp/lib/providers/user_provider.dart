import 'package:myapp/model/korisnik.dart';

import 'base_provider.dart';

class UserProvider extends BaseProvider<Korisnik> {
  UserProvider() : super("Korisnici");

  @override
  Korisnik fromJson(data) {
    return Korisnik.fromJson(data);
  }
}
