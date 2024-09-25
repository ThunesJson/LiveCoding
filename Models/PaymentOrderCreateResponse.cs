namespace LiveCoding.Models
{
    public class PaymentOrderCreateResponse : CommonResponse
    {
        public long PaymentOrderId { get; set; }
        public string PaymentPageUrl { get; set; }

        public new static PaymentOrderCreateResponse GetExample()
        {
            var paymentOrderCreateResponse = new PaymentOrderCreateResponse()
            {
                ReturnCode = 1000,
                ReturnMessage = "Success",
                PaymentOrderId = 99972422011,
                PaymentPageUrl = "https://testpage.limonetik.com/checkout?PaymentOrderid=99972422",
                RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf"
            };

            return paymentOrderCreateResponse;
        }
    }
}
