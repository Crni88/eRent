import 'package:json_annotation/json_annotation.dart';

part 'posjeta.g.dart';

@JsonSerializable()
class Posjeta {
  int? posjetaId;
  int? korisnikId;
  int? nekretninaId;
  String? nazivNekretnine;
  DateTime? datumPosjete;
  String? vrijemePosjete;
  bool? otkazana;

  Posjeta();

  factory Posjeta.fromJson(Map<String, dynamic> json) =>
      _$PosjetaFromJson(json);

  get id => null;

  Map<String, dynamic> toJson() => _$PosjetaToJson(this);
}
