import 'package:myapp/model/fitpasos.dart';
import 'package:myapp/providers/base_provider.dart';

class FITPasosProvider extends BaseProvider<FITPasos> {
  FITPasosProvider() : super("FitPasos");

  @override
  FITPasos fromJson(data) {
    return FITPasos.fromJson(data);
  }
}
