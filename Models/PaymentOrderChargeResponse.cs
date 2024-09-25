using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class PaymentOrderChargeResponse : CommonResponse
    {
        [Required]
        public long OperationId { get; set; }

        public static new PaymentOrderChargeResponse GetExample()
        {
            return new PaymentOrderChargeResponse { ReturnCode = 1000, ReturnMessage = "Success", RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf", OperationId = 875213654782 };
        }
    }
}
