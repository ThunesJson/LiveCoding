using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    [Serializable]
    public class MerchantUrls
    {
        [Required]
        [StringLength(2083)]
        public string ReturnUrl { get; set; }

        [Required]
        [StringLength(2083)]
        public string AbortedUrl { get; set; }

        [Required]
        [StringLength(2083)]
        public string ErrorUrl { get; set; }

        [StringLength(2083)]
        public string ServerNotificationUrl { get; set; }

        public static MerchantUrls GetExample()
        {
            return new MerchantUrls()
            {
                AbortedUrl = "https://www.citronrose.com/Payment_Cancelled.aspx",
                ErrorUrl = "https://www.citronrose.com/Payment_Error.aspx",
                ReturnUrl = "https://www.citronrose.com/Payment_Return.aspx",
                ServerNotificationUrl = "https://www.citronrose.com/Payment_Notification.aspx",
            };
        }

    }
}
