using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class EventStatusUpdate
    {
        [Required]
        public long PaymentOrderId { get; set; }

        [Required]
        public string NewStatus { get; set; }

        public string MerchantOrderId { get; set; }

        public string MerchantId { get; set; }

        public static EventStatusUpdate GetExample()
        {
            var exempleEvent = new EventStatusUpdate()
            {
                PaymentOrderId = 99972422011,
                NewStatus = PaymentOrderStatus.Aborted.ToString(),
                MerchantOrderId = "citronrose_154723",
                MerchantId = "citronrose-fr"
            };

            return exempleEvent;
        }
    }
}
