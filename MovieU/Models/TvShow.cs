﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MovieU.Models
{
    public class TvShow
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

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        
    }
}