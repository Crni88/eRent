
import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/providers/base_provider.dart';

class NekretnineProvider extends BaseProvider<Nekretnina> {
  NekretnineProvider() : super("Nekretnine");

  @override
  Nekretnina fromJson(data) {
    return Nekretnina.fromJson(data);
  }
}
