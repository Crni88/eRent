import 'package:json_annotation/json_annotation.dart';
import 'package:myapp/model/korisnik.dart';

part 'FitPasosModel.g.dart';

@JsonSerializable()
class FitPasos {
  int? pasosId;
  int? korisnikId;
  DateTime? datumIzdavanja;
  DateTime? datumIsteka;
  bool? isValid;
  Korisnik? korisnik;

  FitPasos();

  factory FitPasos.fromJson(Map<String, dynamic> json) =>
      _$FitPasosFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.

  Map<String, dynamic> toJson() => _$FitPasosToJson(this);
}
