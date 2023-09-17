import 'package:myapp/model/FitPasosModel.dart';
import 'package:myapp/providers/base_provider.dart';

class FitPasosProvider extends BaseProvider<FitPasos> {
  FitPasosProvider() : super("FitPasosi");

  @override
  FitPasos fromJson(data) {
    return FitPasos.fromJson(data);
  }
}
