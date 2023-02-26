﻿namespace eRent.Models.Stripe
{
    public class StripePayment
    {
        public string CustomerId { get; set; }
        public string ReceiptEmail { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public long Amount { get; set; }
        public string PaymentId { get; set; }

        public StripePayment(string customerId, string receiptEmail, string description, string currency, long amount, string id)
        {
            CustomerId = customerId;
            ReceiptEmail = receiptEmail;
            Description = description;
            Currency = currency;
            Amount = amount;
        }
    }
}
