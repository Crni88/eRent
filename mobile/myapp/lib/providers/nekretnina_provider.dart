import 'package:myapp/model/nekretnina.dart';
import 'package:myapp/providers/base_provider.dart';

class NekretninaProvider extends BaseProvider<Nekretnina> {
  NekretninaProvider() : super("Nekretnine");

  @override
  Nekretnina fromJson(data) {
    return Nekretnina.fromJson(data);
  }
}
