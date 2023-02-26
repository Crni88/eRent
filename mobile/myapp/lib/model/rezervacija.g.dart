// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'rezervacija.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Rezervacija _$RezervacijaFromJson(Map<String, dynamic> json) => Rezervacija()
  ..nekretninaId = json['nekretninaId'] as int?
  ..mjesecnaRezervacija = json['mjesecnaRezervacija'] as bool?
  ..datumPocetka = json['datumPocetka'] == null
      ? null
      : DateTime.parse(json['datumPocetka'] as String)
  ..datumKraja = json['datumKraja'] == null
      ? null
      : DateTime.parse(json['datumKraja'] as String)
  ..imePrezime = json['imePrezime'] as String?
  ..brojTelefona = json['brojTelefona'] as String?
  ..nazivnekretnine = json['nazivnekretnine'] as String?;

Map<String, dynamic> _$RezervacijaToJson(Rezervacija instance) =>
    <String, dynamic>{
      'nekretninaId': instance.nekretninaId,
      'mjesecnaRezervacija': instance.mjesecnaRezervacija,
      'datumPocetka': instance.datumPocetka?.toIso8601String(),
      'datumKraja': instance.datumKraja?.toIso8601String(),
      'imePrezime': instance.imePrezime,
      'brojTelefona': instance.brojTelefona,
      'nazivnekretnine': instance.nazivnekretnine,
    };
