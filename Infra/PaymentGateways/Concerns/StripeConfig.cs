namespace PaymentGateways.Concerns
{
    public class StripeConfig
    {
        public StripeConfig() { }
        public StripeConfig(string secretKey, string publicKey)
        {
            SecretKey = secretKey;
            PublicKey = publicKey;
        }

        public string SecretKey { get; set; }
        public string PublicKey { get; set; }
    }
}
