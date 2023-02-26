import 'package:myapp/providers/base_provider.dart';

import '../model/stripe/stripecustomer.dart';

class StripeCustomerProvider extends BaseProvider<StripeCustomer> {
  StripeCustomerProvider() : super("api/Stripe/customer/add");

  @override
  StripeCustomer fromJson(data) {
    return StripeCustomer.fromJson(data);
  }
}
