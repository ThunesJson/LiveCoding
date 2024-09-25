namespace LiveCoding.Models
{
    [Serializable]
    public enum PaymentServerOperationType
    {
        None = 0,
        GetBalance_CheckCredential = 100,
        RequestAuthorisation = 200,
        Charge = 300,
        CancelAuthorisation = 400,
        Refund = 500,
        NotImplemented = 600,
    }
}
