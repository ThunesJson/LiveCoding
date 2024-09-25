using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class MerchantOrder
    {
        [Required]
        [StringLength(50)]
        public string Id { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? VatAmount { get; set; }

        [StringLength(3)]
        [Required]
        public string Currency { get; set; }

        public Customer Customer { get; set; }

        public Address ShippingAddress { get; set; }

        public Address BillingAddress { get; set; }

        public CartItem[] CartItems { get; set; }

        public string RawCustom1 { get; set; }
        public string RawCustom2 { get; set; }
        public string RawCustom3 { get; set; }
        public string SearchableCustom1 { get; set; }
        public string SearchableCustom2 { get; set; }


        public static MerchantOrder GetExample()
        {
            return new MerchantOrder()
            {
                Id = "1257981",
                BillingAddress = Address.GetExample(),
                CartItems = new CartItem[] {
                    new CartItem() {
                        Id = "R49203",
                        Label = "MP3PlayerLG4Go",
                        UnitPrice = 65.00M,
                        VAT = 12.74M,
                        Quantity = 1,
                        Category = "Electronics",
                        MerchantCategory1 = "568",
                        MerchantCategory2 = "MP3Players",
                        Brand = "LG",
                        Url = "https://www.citronrose.com/catalog/MP3PlayerLG4Go",
                        RawCustom = "whatever",
                        Delivery = Delivery.GetExample()
                    },
                    new CartItem() {
                        Id = "J89214",
                        Label = "HousseMP3Player",
                        UnitPrice = 20.00M,
                        VAT = 3.92M,
                        Quantity = 1,
                        Category = "Electronics",
                        MerchantCategory1 = "788",
                        MerchantCategory2 = "accessory",
                        Brand = "Logicase",
                        Url = "https://www.citronrose.com/catalog/HousseMP3Player",
                        RawCustom = "whatever",
                        Delivery = Delivery.GetExample()
                    }
                },
                Customer = Customer.GetExample(),
                Currency = "EUR",
                RawCustom1 = "whatever",
                RawCustom2 = "whatever",
                RawCustom3 = "whatever",
                SearchableCustom1 = "whatever",
                SearchableCustom2 = "whatever",
                ShippingAddress = Address.GetExample(),
                TotalAmount = 95.00M,
                VatAmount = 18.62M,
            };
        }
    }
}
