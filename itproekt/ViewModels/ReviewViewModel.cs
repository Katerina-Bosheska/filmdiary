using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using itproekt.Models;

namespace itproekt.ViewModels {
    public class ReviewViewModel {

        [Required(ErrorMessage = "Review text cannot be empty.")]
        public string ReviewText {get;set;}

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public float Rating { get; set; }

        public Movie Movie { get; set; }
    }
}
