using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class PaymentOrder
    {
        public long? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MerchantId { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentPageId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(3)]
        public string Currency { get; set; }

        public string Status { get; set; }

        public DateTime? CreateDate { get; set; }

        public string PaymentPageUrl { get; set; }

        public MerchantUrls MerchantUrls { get; set; }

        public OperationsSummary OperationsSummary { get; set; }

        public PaymentMethod[] PaymentMethods { get; set; }

        public ScheduledOperation[] ScheduledOperations { get; set; }

        public Dvc Dvc { get; set; }

        public MerchantOrder MerchantOrder { get; set; }

        public string MerchantIntegrationMode { get; set; }

        public static PaymentOrder GetExample()
        {
            return new PaymentOrder()
            {
                Id = 99972422011,
                Amount = 95M,
                Status = PaymentOrderStatus.Created.ToString(),
                PaymentPageUrl = "https://testpage.limonetik.com/checkout?PaymentOrderid=99972422",
                CreateDate = DateTime.Now.Date.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second),
                MerchantUrls = MerchantUrls.GetExample(),
                Currency = "EUR",
                MerchantId = "citronrose-fr",
                PaymentPageId = "creditcard",
                MerchantOrder = MerchantOrder.GetExample(),
            };
        }

    }
}
