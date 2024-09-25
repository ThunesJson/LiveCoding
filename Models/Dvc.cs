using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class Dvc
    {
        [Required]
        [StringLength(64)]
        public string CardNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [Required]
        [StringLength(50)]
        public string DVCType { get; set; }

        [Required]
        [StringLength(7)]
        public string Cvv { get; set; }

        [Required]
        [StringLength(100)]
        public string Owner { get; set; }


        public static Dvc GetExample()
        {
            return new Dvc()
            {
                CardNumber = "5132181122223333",
                Cvv = "123",
                DVCType = "Mastercard",
                ExpirationDate = DateTime.Now.Date.AddMonths(1),
                Owner = "48930301",
            };
        }
    }
}
