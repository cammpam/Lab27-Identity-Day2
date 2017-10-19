using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Cameron.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int ApplicationUserID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Skillset 1")]
        public string Role { get; set; }

        [Display(Name = "Skillset 2")]
        public string Role2 { get; set; }
    }
}
