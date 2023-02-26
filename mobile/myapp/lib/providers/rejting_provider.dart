import 'package:myapp/model/rejting.dart';
import 'package:myapp/providers/base_provider.dart';

class RejtingProvider extends BaseProvider<Rejting> {
  RejtingProvider() : super("Rejting");

  @override
  Rejting fromJson(data) {
    return Rejting.fromJson(data);
  }
}
