// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'FitPasosModel.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FitPasos _$FitPasosFromJson(Map<String, dynamic> json) => FitPasos()
  ..pasosId = json['pasosId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..datumIzdavanja = json['datumIzdavanja'] == null
      ? null
      : DateTime.parse(json['datumIzdavanja'] as String)
  ..datumIsteka = json['datumIsteka'] == null
      ? null
      : DateTime.parse(json['datumIsteka'] as String)
  ..isValid = json['isValid'] as bool?
  ..korisnik = json['korisnik'] == null
      ? null
      : Korisnik.fromJson(json['korisnik'] as Map<String, dynamic>);

Map<String, dynamic> _$FitPasosToJson(FitPasos instance) => <String, dynamic>{
      'pasosId': instance.pasosId,
      'korisnikId': instance.korisnikId,
      'datumIzdavanja': instance.datumIzdavanja?.toIso8601String(),
      'datumIsteka': instance.datumIsteka?.toIso8601String(),
      'isValid': instance.isValid,
      'korisnik': instance.korisnik,
    };
