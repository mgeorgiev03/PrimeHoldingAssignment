using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Clothing
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public ClothingType Type { get; set; }
    }

    //using enums to keep the database and the app clean of identical classes and objects
    public enum ClothingType
    {
        Jacket,
        Shirt,
        Trousers,
        Shoes
    }
}
