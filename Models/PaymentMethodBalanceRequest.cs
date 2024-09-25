using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class PaymentMethodBalanceRequest
    {
        [Required]
        [StringLength(50)]
        public string MerchantId { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentPageId { get; set; }

        [Required]
        public Credential[] Credentials { get; set; }

        public static PaymentMethodBalanceRequest GetExample()
        {
            return new PaymentMethodBalanceRequest()
            {
                MerchantId = "citronrose-fr",
                PaymentPageId = "creditcard",
                Credentials = Credential.GetExamples()
            };
        }
    }
}
