// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'korisnik.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Korisnik _$KorisnikFromJson(Map<String, dynamic> json) => Korisnik()
  ..korisnikId = json['korisnikId'] as int?
  ..korsnikIme = json['korsnikIme'] as String?
  ..username = json['username'] as String?
  ..korisnikPrezime = json['korisnikPrezime'] as String?
  ..email = json['email'] as String?
  ..ulogaId = json['ulogaId'] as int?
  ..rejting = json['rejting'] as int?;

Map<String, dynamic> _$KorisnikToJson(Korisnik instance) => <String, dynamic>{
      'korisnikId': instance.korisnikId,
      'korsnikIme': instance.korsnikIme,
      'username': instance.username,
      'korisnikPrezime': instance.korisnikPrezime,
      'email': instance.email,
      'ulogaId': instance.ulogaId,
      'rejting': instance.rejting,
    };
