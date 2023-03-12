import 'package:myapp/model/tagovi/Korisnik/korisnik_tagovi.dart';
import 'package:myapp/providers/base_provider.dart';

class KorisnikTagoviProvider extends BaseProvider<KorisnikTagovi> {
  KorisnikTagoviProvider() : super("KorisnikTagovi");

  @override
  KorisnikTagovi fromJson(data) {
    return KorisnikTagovi.fromJson(data);
  }
}
