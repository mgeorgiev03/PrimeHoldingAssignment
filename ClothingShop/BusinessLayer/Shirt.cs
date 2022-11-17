using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Shirt : BaseClothing
    {
        [Required]
        public ShirtSize Size { get; set; }
    }

    public enum ShirtSize 
    {
        XS,
        S,
        M,
        L,
        XL,
        XXL
    }

}