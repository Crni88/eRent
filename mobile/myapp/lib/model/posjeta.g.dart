// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'posjeta.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Posjeta _$PosjetaFromJson(Map<String, dynamic> json) => Posjeta()
  ..posjetaId = json['posjetaId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..nekretninaId = json['nekretninaId'] as int?
  ..nazivNekretnine = json['nazivNekretnine'] as String?
  ..datumPosjete = json['datumPosjete'] == null
      ? null
      : DateTime.parse(json['datumPosjete'] as String)
  ..vrijemePosjete = json['vrijemePosjete'] as String?
  ..otkazana = json['otkazana'] as bool?;

Map<String, dynamic> _$PosjetaToJson(Posjeta instance) => <String, dynamic>{
      'posjetaId': instance.posjetaId,
      'korisnikId': instance.korisnikId,
      'nekretninaId': instance.nekretninaId,
      'nazivNekretnine': instance.nazivNekretnine,
      'datumPosjete': instance.datumPosjete?.toIso8601String(),
      'vrijemePosjete': instance.vrijemePosjete,
      'otkazana': instance.otkazana,
    };
