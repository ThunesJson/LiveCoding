using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class CartItem
    {
        [StringLength(200)]
        public string Id { get; set; }

        [StringLength(200)]
        public string Label { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? VAT { get; set; }

        public int? Quantity { get; set; }

        public string Category { get; set; }

        [StringLength(100)]
        public string MerchantCategory1 { get; set; }

        [StringLength(100)]
        public string MerchantCategory2 { get; set; }

        [StringLength(100)]
        public string Brand { get; set; }

        [StringLength(2083)]
        public string Url { get; set; }

        public Delivery Delivery { get; set; }

        [StringLength(8000)]
        public string RawCustom { get; set; }

        public static CartItem GetExample()
        {
            return new CartItem()
            {
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
            };
        }
    }
}
