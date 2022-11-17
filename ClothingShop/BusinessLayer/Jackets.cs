using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Jackets : BaseClothing
    {
        [Required]
        public JacketAndTrousersSize Size { get; set; }
    }

    public enum JacketAndTrousersSize
    {

    }
}
