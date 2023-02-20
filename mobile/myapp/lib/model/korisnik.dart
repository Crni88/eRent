import 'package:json_annotation/json_annotation.dart';

part 'korisnik.g.dart';

@JsonSerializable()
class Korisnik {
  late int? korisnikId;
  late String? korisnikIme;
  late String? username;
  late String? korisnikPrezime;
  late String? email;
  late int? ulogaId;
  late int? rejting;

  Korisnik();

  factory Korisnik.fromJson(Map<String, dynamic> json) =>
      _$KorisnikFromJson(json);

  /// Connect the generated [_$ProductToJson] function to the `toJson` method.
  Map<String, dynamic> toJson() => _$KorisnikToJson(this);
}
