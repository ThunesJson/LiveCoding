using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentOrderCancelRequest
    {
        public string PaymentOrderId { get; set; }

        [Required]
        public decimal CancelAmount { get; set; }

        [Required]
        [StringLength(3)]
        public string Currency { get; set; }

        public string MerchantOrderId { get; set; }
        public string MerchantId { get; set; }

        [StringLength(75)]
        public string MerchantOperationId { get; set; }

        public static PaymentOrderCancelRequest GetExample()
        {
            var PaymentOrderCancelRequest = new PaymentOrderCancelRequest()
            {
                PaymentOrderId = "999724220211",
                MerchantOperationId = Guid.NewGuid().ToString(),
                CancelAmount = 20.00m,
                Currency = "EUR"
            };

            return PaymentOrderCancelRequest;
        }
    }
}
