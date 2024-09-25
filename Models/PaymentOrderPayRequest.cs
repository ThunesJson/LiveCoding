using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentOrderPayRequest
    {
        [Required]
        public PaymentOrder PaymentOrder { get; set; }

        [Required]
        public Credential[] Credentials { get; set; }

        public static PaymentOrderPayRequest GetExample()
        {
            var paymentOrderExampleCreate = PaymentOrder.GetExample();
            paymentOrderExampleCreate.Id = null;
            paymentOrderExampleCreate.MerchantUrls.AbortedUrl = null;
            paymentOrderExampleCreate.MerchantUrls.ErrorUrl = null;
            paymentOrderExampleCreate.MerchantUrls.ReturnUrl = null;

            var paymentOrderPayRequest = new PaymentOrderPayRequest() { PaymentOrder = paymentOrderExampleCreate };

            paymentOrderPayRequest.Credentials = Credential.GetExamples();

            return paymentOrderPayRequest;
        }

    }
}
