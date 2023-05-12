import 'package:json_annotation/json_annotation.dart';

part 'rezervacija.g.dart';

@JsonSerializable()
class Rezervacija {
  int? nekretninaId;
  int? korisnikId;
  bool? mjesecnaRezervacija;
  bool? odobrena;
  DateTime? datumPocetka;
  DateTime? datumKraja;
  String? imePrezime;
  String? brojTelefona;
  String? nazivnekretnine;
  bool? otkazana;

  Rezervacija();

  factory Rezervacija.fromJson(Map<String, dynamic> json) =>
      _$RezervacijaFromJson(json);

  get id => null;

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$RezervacijaToJson(this);
}
