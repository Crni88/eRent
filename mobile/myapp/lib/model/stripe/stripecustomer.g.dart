// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'stripecustomer.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

StripeCustomer _$StripeCustomerFromJson(Map<String, dynamic> json) =>
    StripeCustomer()
      ..customerId = json['customerId'] as String?
      ..name = json['name'] as String?
      ..email = json['email'] as String?;

Map<String, dynamic> _$StripeCustomerToJson(StripeCustomer instance) =>
    <String, dynamic>{
      'customerId': instance.customerId,
      'name': instance.name,
      'email': instance.email,
    };
