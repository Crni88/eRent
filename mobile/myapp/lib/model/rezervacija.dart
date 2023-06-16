import 'package:json_annotation/json_annotation.dart';

part 'rezervacija.g.dart';

@JsonSerializable()
class Rezervacija {
  int? rezervacijaId;
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
  bool? odbijena;
  Rezervacija();

  factory Rezervacija.fromJson(Map<String, dynamic> json) =>
      _$RezervacijaFromJson(json);

  get id => null;

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$RezervacijaToJson(this);
}
