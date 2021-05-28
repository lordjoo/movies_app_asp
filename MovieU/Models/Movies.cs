using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace MovieU.Models
{
    public class Movies
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Photo { get; set; }
        
        [Required]
        [StringLength(255)]
        public string StreamUrl { get; set; }
        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
    }
}