using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.D.Entities
{
    public class Notebook : BaseEntity
    {
        [Required]
        public string Model { get; set; }
        [Required]
        public int RAM { get; set; }
        [Required]
        public int ROM { get; set; }
        public string Graphics { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required]
        public double Camera { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public Company Company { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
