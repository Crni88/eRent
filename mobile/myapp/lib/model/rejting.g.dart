// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'rejting.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Rejting _$RejtingFromJson(Map<String, dynamic> json) => Rejting()
  ..rejting1 = json['rejting1'] as int?
  ..komentar = json['komentar'] as String?
  ..nekretnina = json['nekretnina'] as String?
  ..imePrezime = json['imePrezime'] as String?;

Map<String, dynamic> _$RejtingToJson(Rejting instance) => <String, dynamic>{
      'rejting1': instance.rejting1,
      'komentar': instance.komentar,
      'nekretnina': instance.nekretnina,
      'imePrezime': instance.imePrezime,
    };
