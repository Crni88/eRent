import 'package:myapp/model/korisnik.dart';
import 'package:json_annotation/json_annotation.dart';

part 'fitpasos.g.dart';

@JsonSerializable()
class FITPasos {
  int? pasosId;
  int? korisnikId;
  bool? isValid;
  DateTime? datumIzdavanja;
  Korisnik? korisnik;
  FITPasos();

  factory FITPasos.fromJson(Map<String, dynamic> json) =>
      _$FITPasosFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$FITPasosToJson(this);
}
