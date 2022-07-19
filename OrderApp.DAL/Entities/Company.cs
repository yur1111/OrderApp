using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.D.Entities
{
    public class Company : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }

        public ICollection<Computer> Computers { get; set; }
        public ICollection<Notebook> Notebooks { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Headphones> Headphones { get; set; }
        public ICollection<Keyboard> Keyboards { get; set; }
        public ICollection<Mouse> Mice { get; set; }
    }
}
