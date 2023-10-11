
using System.ComponentModel.DataAnnotations;

namespace AnthonyRodriguezejercicio1.Models
{
    public class Burger
    {
        
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }
    }
}
