﻿namespace eRent.Models.Stripe
{
    public class AddStripeCustomer
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public AddStripeCard CreditCard { get; set; }
    }
}