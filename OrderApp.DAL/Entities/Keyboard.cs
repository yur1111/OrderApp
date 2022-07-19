using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.D.Entities
{
    public class Keyboard
    {
        [Required]
        public string Model { get; set; }
        [Required]
        public bool Wire { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public Company Company { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
