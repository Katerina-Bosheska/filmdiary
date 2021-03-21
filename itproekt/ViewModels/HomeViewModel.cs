using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using itproekt.Models;

namespace itproekt.ViewModels {
    public class HomeViewModel {

        public List<MovieActivity> MovieActivity { get; set; }

        public Profile Profile { get; set; }

        public List<Review> Reviews { get; set; }

    }
}
