import 'package:json_annotation/json_annotation.dart';

part 'stripecustomer.g.dart';

@JsonSerializable()
class StripeCustomer {
  String? customerId;
  String? name;
  String? email;
  StripeCustomer();

  factory StripeCustomer.fromJson(Map<String, dynamic> json) =>
      _$StripeCustomerFromJson(json);

  get id => null;

  Map<String, dynamic> toJson() => _$StripeCustomerToJson(this);
}
