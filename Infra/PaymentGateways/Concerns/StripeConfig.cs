namespace PaymentGateways.Concerns
{
    public class StripeConfig
    {
        public StripeConfig() { }
        public StripeConfig(string name) { }

        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
    }
}
