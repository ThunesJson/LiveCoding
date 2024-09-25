namespace LiveCoding.Models
{
    public enum PaymOrcReturnCode
    {
        Success = 1000,
        InvalidData = 2000,
        OperationNotAllowed = 2500,
        Refused = 3000,
        TechnicalError = 5000,
        ServiceNotAvailable = 5050,
    }
}
