using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class Fee
    {
        [Required]
        [StringLength(50)]
        public string Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public static Fee GetExample()
        {
            var exempleFee = new Fee()
            {
                Id = "Marketplace fees",
                Amount = 1,
            };

            return exempleFee;
        }
    }
}
