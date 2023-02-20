// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'nekretnina_tagovi.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

NekretninaTagovi _$NekretninaTagoviFromJson(Map<String, dynamic> json) =>
    NekretninaTagovi()
      ..nekretninaId = json['nekretninaId'] as int?
      ..tags = json['tags'] as List<dynamic>?;

Map<String, dynamic> _$NekretninaTagoviToJson(NekretninaTagovi instance) =>
    <String, dynamic>{
      'nekretninaId': instance.nekretninaId,
      'tags': instance.tags,
    };
