using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter movie title")]
        [StringLength(255)]
        [Display(Name = "Movie Title")]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        [Required(ErrorMessage = "Please select movie category")]
        [Display(Name = "Select Movie category")]
        public byte GenreId { get; set; }
    }
}