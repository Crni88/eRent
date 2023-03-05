// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'nekretnina_tagovi.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

NekretninaTagovi _$NekretninaTagoviFromJson(Map<String, dynamic> json) =>
    NekretninaTagovi()
      ..ntId = json['ntId'] as int?
      ..nekretninaId = json['nekretninaId'] as int?
      ..tagID = json['tagID'] as int?
      ..isActive = json['isActive'] as bool?;

Map<String, dynamic> _$NekretninaTagoviToJson(NekretninaTagovi instance) =>
    <String, dynamic>{
      'ntId': instance.ntId,
      'nekretninaId': instance.nekretninaId,
      'tagID': instance.tagID,
      'isActive': instance.isActive,
    };
