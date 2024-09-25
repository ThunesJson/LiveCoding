namespace LiveCoding.Models
{
    [Serializable]
    public class OperationsSummary
    {

        public decimal HeldAmount { get; set; }

        public DateTime? HoldReleaseMaxDate { get; set; }

        public decimal AuthorizedAmount { get; set; }

        public decimal ChargedAmount { get; set; }

        public decimal ChargingAmount { get; set; }

        public decimal ChargeableAmount { get; set; }

        public DateTime? EndOfChargeHonorPeriod { get; set; }

        public DateTime? EndOfChargePeriod { get; set; }

        public decimal CancelledAmount { get; set; }

        public decimal CancellingAmount { get; set; }

        public decimal CancellableAmount { get; set; }

        public DateTime? EndOfCancelPeriod { get; set; }

        public decimal RefundedAmount { get; set; }

        public decimal RefundingAmount { get; set; }

        public decimal RefundableAmount { get; set; }

        public static OperationsSummary GetExample()
        {
            return new OperationsSummary()
            {
                HeldAmount = 30.00M,
                HoldReleaseMaxDate = DateTime.Now.AddDays(10).Date.AddSeconds(-1),
                AuthorizedAmount = 40.00M,
                ChargedAmount = 30M,
                ChargingAmount = 0M,
                ChargeableAmount = 20.00M,
                EndOfChargeHonorPeriod = DateTime.Now.AddDays(10).Date.AddSeconds(-1),
                EndOfChargePeriod = DateTime.Now.AddDays(10).Date.AddSeconds(-1),
                CancelledAmount = 50M,
                CancellingAmount = 0M,
                CancellableAmount = 20.00M,
                EndOfCancelPeriod = DateTime.Now.AddDays(10).Date.AddSeconds(-1),
                RefundedAmount = 0M,
                RefundingAmount = 0M,
                RefundableAmount = 30.00M,
            };
        }
    }
}
