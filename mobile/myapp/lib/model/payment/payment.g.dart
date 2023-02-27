// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'payment.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Payment _$PaymentFromJson(Map<String, dynamic> json) => Payment()
  ..naslov = json['naslov'] as String?
  ..korisnikPaymentId = json['korisnikPaymentId'] as int?
  ..isProcessed = json['isProcessed'] as bool?
  ..nekretninaPayment = json['nekretninaPayment'] as int?
  ..komentar = json['komentar'] as String?
  ..iznos = (json['iznos'] as num?)?.toDouble()
  ..mjesecno = json['mjesecno'] as bool?
  ..nekretnina = json['nekretnina'] as String?;

Map<String, dynamic> _$PaymentToJson(Payment instance) => <String, dynamic>{
      'naslov': instance.naslov,
      'korisnikPaymentId': instance.korisnikPaymentId,
      'isProcessed': instance.isProcessed,
      'nekretninaPayment': instance.nekretninaPayment,
      'komentar': instance.komentar,
      'iznos': instance.iznos,
      'mjesecno': instance.mjesecno,
      'nekretnina': instance.nekretnina,
    };
