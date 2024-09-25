namespace LiveCoding.Models
{
    public class PaymentOrderPayResponse : CommonResponse
    {
        public long? PaymentOrderId { get; set; }

        public string PaymentPageUrl { get; set; }

        public string Status { get; set; }

        public static new PaymentOrderPayResponse GetExample()
        {
            var PaymentOrderCreateResponse = new PaymentOrderPayResponse()
            {
                ReturnCode = (int)PaymOrcReturnCode.Success,
                ReturnMessage = PaymOrcReturnCode.Success.ToString(),
                PaymentOrderId = 99972422011,
                Status = PaymentOrderStatus.Authorized.ToString(),
                RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf"
            };

            return PaymentOrderCreateResponse;
        }
    }
}
