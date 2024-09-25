namespace LiveCoding.Models
{
    public enum PaymentOrderStatus
    {
        UnKnown,
        Created,
        Payment_In_Progress,
        Aborted,
        Refused,
        Error,
        Authorizing,
        Authorized,
        Cancelled,
        Charged,
        Refunded,
    }
}
