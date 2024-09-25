using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class Customer
    {
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Id { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(25)]
        public string HomePhone { get; set; }

        [StringLength(25)]
        public string MobilePhone { get; set; }

        [StringLength(5)]
        public string Culture { get; set; }

        [StringLength(8000)]
        public string RawCustom { get; set; }

        public static Customer GetExample()
        {
            return new Customer()
            {
                Email = "testachat@limonetik.com",
                Culture = "fr-FR",
                FirstName = "Jean",
                LastName = "Dupont",
                HomePhone = "+33(0)175757575",
                MobilePhone = "+33(0)675757575",
                Title = "M",
                CompanyName = "Limonetik",
                Id = "123321",
                RawCustom = "whatever",
                Type = "Individual",
            };
        }

    }
}
