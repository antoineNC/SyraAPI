using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Syra.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Last Name"), Required]
        public string LastName { get; set; }

        [Display(Name = "First Name"), Required]
        public string FirstName { get; set; }

        [Display(Name = "Hire Date"), DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        public ICollection<Resource> Resources { get; set; }
    }
}