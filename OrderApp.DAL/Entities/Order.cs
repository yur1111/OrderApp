using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.D.Entities
{
    public class Order : BaseEntity
    {
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public double Sum { get; set; }
        [Required]
        public string DeliveryDate { get; set; }
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        public ICollection<Computer> Computers { get; set; }
        public ICollection<Notebook> Notebooks { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Headphones> Headphones { get; set; }
        public ICollection<Keyboard> Keyboards { get; set; }
        public ICollection<Mouse> Mice { get; set; }
    }
}
