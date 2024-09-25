using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentOrderRefundRequest
    {
        public string PaymentOrderId { get; set; }

        [Required]
        public decimal RefundAmount { get; set; }

        [Required]
        [StringLength(3)]
        public string Currency { get; set; }

        public string MerchantOrderId { get; set; }
        public string MerchantId { get; set; }

        public Fee[] Fees { get; set; }

        [StringLength(75)]
        public string MerchantOperationId { get; set; }

        public static PaymentOrderRefundRequest GetExample()
        {
            var PaymentOrderRefundRequest = new PaymentOrderRefundRequest()
            {
                PaymentOrderId = "999724220211",
                RefundAmount = 75.00m,
                Currency = "EUR",
                MerchantOperationId = Guid.NewGuid().ToString(),
                Fees = new Fee[]
                {
                    Fee.GetExample()
                }
            };

            return PaymentOrderRefundRequest;
        }
    }
}
