using System;
using System.ComponentModel.DataAnnotations;

namespace MovieU.Models
{
    public class TvShows
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
        
        [Required]
        public int Episode { get; set; }
        
    }
}