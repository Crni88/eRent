import 'package:myapp/providers/base_provider.dart';

import '../model/stripe/addpayment.dart';

class AddPaymentProvider extends BaseProvider<AddPayment> {
  AddPaymentProvider() : super("api/Stripe/payment/add");

  @override
  AddPayment fromJson(data) {
    return AddPayment.fromJson(data);
  }
}
