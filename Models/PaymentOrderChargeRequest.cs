using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentOrderChargeRequest
    {
        public string PaymentOrderId { get; set; }

        [Required]
        public decimal ChargeAmount { get; set; }

        [Required]
        [StringLength(3)]
        public string Currency { get; set; }

        public string MerchantOrderId { get; set; }
        public string MerchantId { get; set; }

        public Fee[] Fees { get; set; }

        [StringLength(75)]
        public string MerchantOperationId { get; set; }

        public static PaymentOrderChargeRequest GetExample()
        {
            var PaymentOrderChargeRequest = new PaymentOrderChargeRequest()
            {
                PaymentOrderId = "999724220211",
                ChargeAmount = 75.00m,
                Currency = "EUR",
                MerchantOperationId = Guid.NewGuid().ToString()
            };

            return PaymentOrderChargeRequest;
        }
    }
}
