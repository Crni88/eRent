import 'package:json_annotation/json_annotation.dart';

part 'addpayment.g.dart';

@JsonSerializable()
class AddPayment {
  String? customerId;
  String? paymentId;
  String? receiptEmail;
  String? description;
  String? currency;
  double? amount;
  AddPayment();

  factory AddPayment.fromJson(Map<String, dynamic> json) =>
      _$AddPaymentFromJson(json);

  get id => null;

  Map<String, dynamic> toJson() => _$AddPaymentToJson(this);
}
