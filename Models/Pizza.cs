using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public Pizza()
        {

        }

        public Pizza(string name, string description, double price, string image)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Image = image;
        }
    }
}
