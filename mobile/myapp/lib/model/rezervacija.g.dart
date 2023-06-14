// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'rezervacija.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Rezervacija _$RezervacijaFromJson(Map<String, dynamic> json) => Rezervacija()
  ..rezervacijaId = json['rezervacijaId'] as int?
  ..nekretninaId = json['nekretninaId'] as int?
  ..korisnikId = json['korisnikId'] as int?
  ..mjesecnaRezervacija = json['mjesecnaRezervacija'] as bool?
  ..odobrena = json['odobrena'] as bool?
  ..datumPocetka = json['datumPocetka'] == null
      ? null
      : DateTime.parse(json['datumPocetka'] as String)
  ..datumKraja = json['datumKraja'] == null
      ? null
      : DateTime.parse(json['datumKraja'] as String)
  ..imePrezime = json['imePrezime'] as String?
  ..brojTelefona = json['brojTelefona'] as String?
  ..nazivnekretnine = json['nazivnekretnine'] as String?
  ..otkazana = json['otkazana'] as bool?;

Map<String, dynamic> _$RezervacijaToJson(Rezervacija instance) =>
    <String, dynamic>{
      'rezervacijaId': instance.rezervacijaId,
      'nekretninaId': instance.nekretninaId,
      'korisnikId': instance.korisnikId,
      'mjesecnaRezervacija': instance.mjesecnaRezervacija,
      'odobrena': instance.odobrena,
      'datumPocetka': instance.datumPocetka?.toIso8601String(),
      'datumKraja': instance.datumKraja?.toIso8601String(),
      'imePrezime': instance.imePrezime,
      'brojTelefona': instance.brojTelefona,
      'nazivnekretnine': instance.nazivnekretnine,
      'otkazana': instance.otkazana,
    };
