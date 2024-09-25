using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentOrderCreateRequest
    {
        [Required]
        public PaymentOrder PaymentOrder { get; set; }

        public static PaymentOrderCreateRequest GetExample()
        {
            var paymentOrderExampleCreate = PaymentOrder.GetExample();
            paymentOrderExampleCreate.Id = null;
            return new PaymentOrderCreateRequest { PaymentOrder = paymentOrderExampleCreate };
        }

    }
}
