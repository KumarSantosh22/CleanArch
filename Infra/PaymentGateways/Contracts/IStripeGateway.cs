using PaymentGateways.Concerns;
using Stripe;

namespace PaymentGateways.Contracts
{
    public interface IStripeGateway
    {
        // Customer
        Task<Customer> CreateCustomerAsync(CustomerInfo customerInfo);
        Task<Customer> GetCustomerAsync(string id);
        Task<Customer> UpdateCustomer(string id, CustomerUpdateInfo updateOptions);
        Task<PaymentIntent> GetPaymentIntentAsync(PaymentIntentInfo paymentIntentInfo);

        // Payment
        Task<JsPaymentIntent> CreatePaymentIntent(PaymentIntentInfo paymentIntentInfo, CustomerInfo customerInfo);
        Task<JsPaymentIntent> CreatePaymentIntent(PaymentIntentInfo paymentIntentInfo, string customerId);
    }
}
