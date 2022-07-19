using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.D.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
