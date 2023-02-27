import 'package:json_annotation/json_annotation.dart';

part 'payment.g.dart';

@JsonSerializable()
class Payment {
  int? paymentRequestId;
  String? naslov;
  int? korisnikPaymentId;
  bool? isProcessed;
  int? nekretninaPayment;
  String? komentar;
  double? iznos;
  bool? mjesecno;
  String? nekretnina;

  Payment();

  factory Payment.fromJson(Map<String, dynamic> json) =>
      _$PaymentFromJson(json);

  Map<String, dynamic> toJson() => _$PaymentToJson(this);
}
