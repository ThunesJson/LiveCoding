using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace LiveCoding.Models
{
    public class Credential
    {
        [Required]
        [XmlAttribute]
        public string name { get; set; }

        [Required]
        [XmlText]
        public string credential { get; set; }


        public static Credential GetExample()
        {
            return new Credential()
            {
                name = "PAN",
                credential = "36695454775512",
            };
        }

        public static Credential[] GetExamples()
        {
            return (new List<Credential>(){
                new Credential()
                {
                    name = "PAN",
                    credential = "36695454775512",
                },
                new Credential()
                {
                    name = "SaCarte",
                    credential = "MaCarte",
                },
            }).ToArray();
        }
    }
}
