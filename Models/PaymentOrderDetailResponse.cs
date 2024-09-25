namespace LiveCoding.Models
{
    public class PaymentOrderDetailResponse : CommonResponse
    {
        public PaymentOrder PaymentOrder { get; set; }

        public static new PaymentOrderDetailResponse GetExample()
        {
            var PaymentOrderDetailResponse = new PaymentOrderDetailResponse()
            {
                ReturnCode = 1000,
                ReturnMessage = "Success",
                RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf",
                PaymentOrder = PaymentOrder.GetExample()
            };

            return PaymentOrderDetailResponse;
        }
    }
}
