import 'package:myapp/model/posjeta.dart';
import 'package:myapp/providers/base_provider.dart';

class PosjetaProvider extends BaseProvider<Posjeta> {
  PosjetaProvider() : super("Posjeta");

  @override
  Posjeta fromJson(data) {
    return Posjeta.fromJson(data);
  }
}
