// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'nekretnina_search_object.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Nekretnina_search_object _$Nekretnina_search_objectFromJson(
        Map<String, dynamic> json) =>
    Nekretnina_search_object()
      ..NameFTS = json['NameFTS'] as String?
      ..CijenaMin = json['CijenaMin'] as int?
      ..CijenaMax = json['CijenaMax'] as int?
      ..BrojSoba = json['BrojSoba'] as int?;

Map<String, dynamic> _$Nekretnina_search_objectToJson(
        Nekretnina_search_object instance) =>
    <String, dynamic>{
      'NameFTS': instance.NameFTS,
      'CijenaMin': instance.CijenaMin,
      'CijenaMax': instance.CijenaMax,
      'BrojSoba': instance.BrojSoba,
    };
