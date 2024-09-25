using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class PaymentMethod
    {
        [StringLength(20)]
        [Required]
        public string Type { get; set; }

        [StringLength(50)]
        [Required]
        public string Brand { get; set; }

        [StringLength(100)]
        public string Ref { get; set; }

        [StringLength(50)]
        [Required]
        public string Processor { get; set; }

        public decimal AuthorizedAmount { get; set; }

        public decimal AuthorizingAmount { get; set; }

        public decimal DebitedAmount { get; set; }

        public decimal RecreditedAmount { get; set; }

        [StringLength(8000)]
        public string RawCustom { get; set; }

        public static PaymentMethod GetExample()
        {
            return new PaymentMethod()
            {
                Type = "CreditCard",
                Brand = "Visa",
                Ref = "4587 5496 xxxx xxxx",
                Processor = "Payline",
                AuthorizedAmount = 40M,
                AuthorizingAmount = 0M,
                DebitedAmount = 0M,
                RecreditedAmount = 0M,
            };
        }
    }
}
