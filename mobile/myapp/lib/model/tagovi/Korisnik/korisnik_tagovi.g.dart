// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'korisnik_tagovi.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

KorisnikTagovi _$KorisnikTagoviFromJson(Map<String, dynamic> json) =>
    KorisnikTagovi()
      ..ktId = json['ktId'] as int?
      ..korisnikId = json['korisnikId'] as int?
      ..tagId = json['tagId'] as int?
      ..isActive = json['isActive'] as bool?;

Map<String, dynamic> _$KorisnikTagoviToJson(KorisnikTagovi instance) =>
    <String, dynamic>{
      'ktId': instance.ktId,
      'korisnikId': instance.korisnikId,
      'tagId': instance.tagId,
      'isActive': instance.isActive,
    };
