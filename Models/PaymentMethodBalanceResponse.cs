using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentMethodBalanceResponse : CommonResponse
    {
        [Required]
        [StringLength(50)]
        public string MerchantId { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentPageId { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(3)]
        public string Currency { get; set; }

        public new static PaymentMethodBalanceResponse GetExample()
        {
            return new PaymentMethodBalanceResponse()
            {
                ReturnCode = 1000,
                ReturnMessage = "Succeeded",
                RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf",
                MerchantId = "citronrose-fr",
                PaymentPageId = "creditcard",
                Amount = 12.34M,
                Currency = "USD"
            };
        }
    }
}
