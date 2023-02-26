// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'addpayment.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

AddPayment _$AddPaymentFromJson(Map<String, dynamic> json) => AddPayment()
  ..customerId = json['customerId'] as String?
  ..receiptEmail = json['receiptEmail'] as String?
  ..description = json['description'] as String?
  ..currency = json['currency'] as String?
  ..amount = (json['amount'] as num?)?.toDouble();

Map<String, dynamic> _$AddPaymentToJson(AddPayment instance) =>
    <String, dynamic>{
      'customerId': instance.customerId,
      'receiptEmail': instance.receiptEmail,
      'description': instance.description,
      'currency': instance.currency,
      'amount': instance.amount,
    };
