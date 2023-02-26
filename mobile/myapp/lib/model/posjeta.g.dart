// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'posjeta.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Posjeta _$PosjetaFromJson(Map<String, dynamic> json) => Posjeta()
  ..posjetaId = json['posjetaId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..nekretninaId = json['nekretninaId'] as int?
  ..nazivnekretnine = json['nazivnekretnine'] as String?
  ..datumPosjete = json['datumPosjete'] == null
      ? null
      : DateTime.parse(json['datumPosjete'] as String)
  ..vrijemePosjete = json['vrijemePosjete'] as String?;

Map<String, dynamic> _$PosjetaToJson(Posjeta instance) => <String, dynamic>{
      'posjetaId': instance.posjetaId,
      'korisnikId': instance.korisnikId,
      'nekretninaId': instance.nekretninaId,
      'nazivnekretnine': instance.nazivnekretnine,
      'datumPosjete': instance.datumPosjete?.toIso8601String(),
      'vrijemePosjete': instance.vrijemePosjete,
    };
