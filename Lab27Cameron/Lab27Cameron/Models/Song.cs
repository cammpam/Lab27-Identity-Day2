using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Cameron.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Song Credit")]
        public string Contributor1Role { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Contributor1 { get; set; }
        [Display(Name = "Song Credit")]
        public string Contributor2Role { get; set; }
        [Display(Name = "Name")]
        public string Contributor2 { get; set; }
        [Display(Name = "Song Credit")]
        public string Contributor3Role { get; set; }
        [Display(Name = "Name")]
        public string Contributor3 { get; set; }
    }
}
