using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Syra.Models
{
    public class Department
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3), Required]
        public string Name { get; set; }

        public int? UserId { get; set; }
        public User Administrator { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}