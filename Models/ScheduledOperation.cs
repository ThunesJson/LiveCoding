using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class ScheduledOperation
    {
        public long? Id { get; set; }

        public long? ParentId { get; set; }

        public long? MerchantOperationId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        public int Delay { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? ScheduledDate { get; set; }

        public static ScheduledOperation GetExample()
        {
            return new ScheduledOperation()
            {
                Id = 123456,
                ParentId = 123457,
                Type = ScheduledOperationType.ChargePaymentOrder.ToString(),
                Delay = 30,
                Amount = 70.50M,
                ScheduledDate = DateTime.Now.AddDays(30).Date,
                MerchantOperationId = 123456789,
            };
        }

        public static ScheduledOperation GetExamplePaymentOrder(PaymentOrder pPaymentOrder)
        {
            return new ScheduledOperation()
            {
                Type = ScheduledOperationType.ChargePaymentOrder.ToString(),
                Delay = 30,
                Amount = (pPaymentOrder.Amount > 10) ? pPaymentOrder.Amount - 10 : pPaymentOrder.Amount - 1,
            };
        }
    }
}
