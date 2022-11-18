using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Shoes : BaseClothing
    {
        [Required]
        public ShoeSize Size { get; set; }
    }

    public enum ShoeSize
    {

    }
}
