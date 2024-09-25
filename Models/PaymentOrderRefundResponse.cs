using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentOrderRefundResponse : CommonResponse
    {
        [Required]
        public long OperationId { get; set; }

        public static new PaymentOrderRefundResponse GetExample()
        {
            return new PaymentOrderRefundResponse { ReturnCode = 1000, ReturnMessage = "Success", RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf", OperationId = 875213654782 };
        }
    }
}
