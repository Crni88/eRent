// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'fitpasos.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FITPasos _$FITPasosFromJson(Map<String, dynamic> json) => FITPasos()
  ..pasosId = json['pasosId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..isValid = json['isValid'] as bool?
  ..datumIzdavanja = json['datumIzdavanja'] == null
      ? null
      : DateTime.parse(json['datumIzdavanja'] as String)
  ..korisnik = json['korisnik'] == null
      ? null
      : Korisnik.fromJson(json['korisnik'] as Map<String, dynamic>);

Map<String, dynamic> _$FITPasosToJson(FITPasos instance) => <String, dynamic>{
      'pasosId': instance.pasosId,
      'korisnikId': instance.korisnikId,
      'isValid': instance.isValid,
      'datumIzdavanja': instance.datumIzdavanja?.toIso8601String(),
      'korisnik': instance.korisnik,
    };
