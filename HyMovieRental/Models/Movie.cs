﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HyMovieRental.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Genre")]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [DisplayName("Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        [DisplayName("Number in Stock")]
        public byte NumberInStock { get; set; }

        [Display(Name = "Number available")]
        public byte NumberAvailable { get; set; }
    }
}