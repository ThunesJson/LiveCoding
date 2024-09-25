using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class Address
    {
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(200)]
        public string Address1 { get; set; }

        [StringLength(200)]
        public string Address2 { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(2)]
        public string Country { get; set; }

        [StringLength(25)]
        public string HomePhone { get; set; }

        [StringLength(25)]
        public string MobilePhone { get; set; }

        [StringLength(8000)]
        public string RawCustom { get; set; }

        public static Address GetExample()
        {
            return new Address()
            {
                Address1 = "13 bd de Rochechouart",
                Address2 = "Gate A",
                City = "Paris",
                Country = "FR",
                FirstName = "Jean",
                LastName = "Dupont",
                HomePhone = "+33(0)175757575",
                MobilePhone = "+33(0)675757575",
                Title = "M",
                ZipCode = "75009",
                RawCustom = "whatever",
                CompanyName = "Limonetik",
            };
        }
    }
}
