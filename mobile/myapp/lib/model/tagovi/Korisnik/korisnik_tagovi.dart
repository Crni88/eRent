import 'package:json_annotation/json_annotation.dart';

part 'korisnik_tagovi.g.dart';

@JsonSerializable()
class KorisnikTagovi {
  int? ktId;
  int? korisnikId;
  int? tagId;
  bool? isActive;

  KorisnikTagovi();

  factory KorisnikTagovi.fromJson(Map<String, dynamic> json) =>
      _$KorisnikTagoviFromJson(json);

  get id => null;

  Map<String, dynamic> toJson() => _$KorisnikTagoviToJson(this);
}
