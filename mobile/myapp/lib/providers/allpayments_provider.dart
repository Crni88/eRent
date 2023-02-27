import 'package:myapp/model/payment/payment.dart';
import 'package:myapp/providers/base_provider.dart';

class AllPaymentsProvider extends BaseProvider<Payment> {
  AllPaymentsProvider() : super("PaymentRequest");

  @override
  Payment fromJson(data) {
    return Payment.fromJson(data);
  }
}
