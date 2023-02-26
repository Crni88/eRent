namespace eRent.Models.Stripe
{
    public class StripeCustomer
    {
        public StripeCustomer(string name, string email, string id)
        {
            Name = name;
            Email = email;
        }

        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
