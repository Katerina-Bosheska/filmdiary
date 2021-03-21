using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using itproekt.Models;

namespace itproekt.ViewModels {
    public class MovieDetailsViewModel {

        public Movie Movie { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
