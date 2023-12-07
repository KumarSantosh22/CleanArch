using Stripe;

namespace PaymentGateways.Concerns
{
    public class CustomerInfo : CustomerCreateOptions
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public AddressInfo Address { get; set; }
    }

    public class AddressInfo : AddressOptions
    {

    }
}
