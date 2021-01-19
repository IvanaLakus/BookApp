using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class Contact
    {
        [Required]
        [StringLength(100)]
        [MinLength(3, ErrorMessage = "Name can't be less then 3 charactes")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(300)]
        public string Message { get; set; }

    }
}
