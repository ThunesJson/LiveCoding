namespace LiveCoding.Models
{
    [Serializable]
    public enum OperationResponseStatus
    {
        Ok = 100,
        NotOk = 101,
        Pending = 102,

        CustomerPaymentAborted = 201,
        CustomerPaymentTimeout = 202,

        DeclinedCustomerBadCredential = 301,
        DeclinedCustomerCredentialExpired = 302,
        DeclinedCustomerBadAddress = 303,
        DeclinedCustomerAmountExceedsLimit = 304,

        DeclinedActionNotAuthorizedProduct = 401,
        DeclinedActionNotAuthorizedDate = 402,
        DeclinedAmountNotValid = 403,
        DeclinedInvalidCurrency = 404,

        TechnicalError = 500,
        BadCredentials = 501,
        NotEnoughMoney = 502,
        Timeout = 503,
        LimonetikTechnicalError = 504,
        NotAvailable = 505,
        ThunesBadRequest = 506,
        ThunesInvalidToken = 507,
        ThunesDuplicatedMessage = 508,

        PaymentMethodMerchantNotRecognized = 601,
        PaymentMethodMerchantNotWellConfigured = 602,
        PaymentMethodServerDown = 603,
        PaymentMethodInvalidResponse = 604,

        DeclinedFraudScoreKO = 701,
        DeclinedFraudPaymentMethodStolen = 702,
        DeclinedFraudPaymentMethodBlocked = 703,
        DeclinedFraudPaymentMethodRestricted = 704,
        DeclinedFraudTooManyTries = 705,
        DeclinedFraudTooManyPayment = 706
    }
}
