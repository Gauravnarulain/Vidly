using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        [StringLength(255)]
        [Required]
        public string Title { get; set; }
    }
}