using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Syra.Models
{
    public class Resource
    {
        [Display(Name = "Number")]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 4), Required]
        public string nameResource { get; set; }
        public string descriptionResource { get; set; }

        public string Links { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }  
        public ICollection<User> Users { get; set; }
    }
}