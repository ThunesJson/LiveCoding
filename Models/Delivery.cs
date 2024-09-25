using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class Delivery
    {
        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Label { get; set; }

        [StringLength(50)]
        public string Speed { get; set; }

        public DateTime? ExpectedDate { get; set; }

        public int? ExpectedDelay { get; set; }

        [StringLength(8000)]
        public string RawCustom { get; set; }

        public static Delivery GetExample()
        {
            return new Delivery()
            {
                Type = "Carrier",
                Label = "COLISSIMO",
                Speed = "Standard",
                ExpectedDate = DateTime.Now.Date.AddDays(1).AddSeconds(-1),
                ExpectedDelay = 15,
                RawCustom = "whatever",
            };
        }
    }
}
