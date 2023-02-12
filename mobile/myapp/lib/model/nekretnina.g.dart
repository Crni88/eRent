// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'nekretnina.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Nekretnina _$NekretninaFromJson(Map<String, dynamic> json) => Nekretnina()
  ..nekretninaId = json['nekretninaId'] as int?
  ..nazivNekretnine = json['nazivNekretnine'] as String?
  ..cijena = json['cijena'] as int?
  ..brojSoba = json['brojSoba'] as int?
  ..grad = json['grad'] as String?
  ..slika = json['slika'] as String?
  ..izdvojena = json['izdvojena'] as bool
  ..opis = json['opis'] as String?;

Map<String, dynamic> _$NekretninaToJson(Nekretnina instance) =>
    <String, dynamic>{
      'nekretninaId': instance.nekretninaId,
      'nazivNekretnine': instance.nazivNekretnine,
      'cijena': instance.cijena,
      'brojSoba': instance.brojSoba,
      'grad': instance.grad,
      'slika': instance.slika,
      'izdvojena': instance.izdvojena,
      'opis': instance.opis,
    };
