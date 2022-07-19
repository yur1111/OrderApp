using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.D.Entities
{
    public class Phone : BaseEntity
    {
        [Required]
        public string Model { get; set; }
        [Required]
        public int RAM { get; set; }
        [Required]
        public int ROM { get; set; }
        [Required]
        public int Camera { get; set; }
        [Required]
        public double Screen { get; set; }
        [Required]
        public int Battery { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public Company Company { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
