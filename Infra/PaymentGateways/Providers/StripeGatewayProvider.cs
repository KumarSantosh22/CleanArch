using Newtonsoft.Json;
using PaymentGateways.Concerns;
using PaymentGateways.Contracts;
using Stripe;

namespace PaymentGateways.Providers
{
    public class StripeGatewayProvider : IStripeGateway
    {
        public StripeGatewayProvider() { }

        public async Task<JsPaymentIntent> CreatePaymentIntent(PaymentIntentInfo paymentIntentInfo, CustomerInfo customerInfo)
        {
            // Creating Customer
            Customer customer = await CreateCustomerAsync(customerInfo);
            paymentIntentInfo.Customer = customer.Id;
            paymentIntentInfo.ReceiptEmail = customer.Email;

            // Creating Payment Intent
            PaymentIntent intent = await GetPaymentIntentAsync(paymentIntentInfo);
            return JsonConvert.DeserializeObject<JsPaymentIntent>(intent.StripeResponse.Content);
        }

        public async Task<JsPaymentIntent> CreatePaymentIntent(PaymentIntentInfo paymentIntentInfo, string customerId)
        {
            // Creating Customer
            Customer customer = await GetCustomerAsync(customerId);
            paymentIntentInfo.Customer = customer.Id;
            paymentIntentInfo.ReceiptEmail = customer.Email;

            // Creating Payment Intent
            PaymentIntent intent = await GetPaymentIntentAsync(paymentIntentInfo);
            return JsonConvert.DeserializeObject<JsPaymentIntent>(intent.StripeResponse.Content);
        }

        public async Task<Customer> CreateCustomerAsync(CustomerInfo customerInfo)
        {
            CustomerCreateOptions customerOptions = new CustomerCreateOptions
            {
                Email = customerInfo.Email,
                Name = customerInfo.Name,
                Phone = customerInfo.Phone,
                Address = new AddressOptions
                {
                    City = customerInfo.Address.City,
                    State = customerInfo.Address.State,
                    Country = customerInfo.Address.Country,
                    PostalCode = customerInfo.Address.PostalCode,
                    Line1 = customerInfo.Address.Line1,
                    Line2 = customerInfo.Address.Line2
                }
            };
            CustomerService service = new CustomerService();
            Customer customer = await service.CreateAsync(customerOptions);
            return customer;
        }

        public async Task<Customer> GetCustomerAsync(string id)
        {
            CustomerService service = new CustomerService();
            Customer customer = await service.GetAsync(id);
            return customer;
        }

        public async Task<PaymentIntent> GetPaymentIntentAsync(PaymentIntentInfo paymentIntentInfo)
        {
            PaymentIntentCreateOptions paymentIntentCreateOptions = new PaymentIntentCreateOptions
            {
                Amount = 2000,
                Currency = "inr",
                ReceiptEmail = paymentIntentInfo.ReceiptEmail,
                // CustomerId
                Customer = paymentIntentInfo.Customer,
                Description = paymentIntentInfo.Description,
                PaymentMethodTypes = new List<string>
                {
                    "card"
                }
            };
            PaymentIntentService paymentIntentService = new PaymentIntentService();
            PaymentIntent intent = await paymentIntentService.CreateAsync(paymentIntentCreateOptions);
            return intent;
        }

        public async Task<Customer> UpdateCustomer(string id, CustomerUpdateInfo updateOptions)
        {
            CustomerService service = new CustomerService();
            Customer customer = await service.UpdateAsync(id, updateOptions);
            return customer;
        }

    }
}

/*
    // Payment IntentOptions
    PaymentIntentCreateOptions paymentIntentCreateOptions = new PaymentIntentCreateOptions
    {
        Amount = 2000,  // 2000 = 20 Rupees 00 Paise
        Currency = "inr",
        ReceiptEmail = customer.Email,
        Customer = customer.Id,
        Description = "Payment Intent Created",
        PaymentMethodTypes = new List<string>
        {
            "card"
        }
    };       
*/