using System.ComponentModel.DataAnnotations;

namespace LiveCoding.Models
{
    public class CommonResponse
    {
        [Required]
        public string RequestId { get; set; }

        [Required]
        public string ReturnMessage { get; set; }

        [Required]
        public int ReturnCode { get; set; }

        public static CommonResponse GetExample()
        {
            return new CommonResponse { ReturnCode = 1000, ReturnMessage = "Succeeded", RequestId = "1b07e7c6-0d92-4cc8-b500-75510acb49bf" };
        }
    }
}
