using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using itproekt.Models;

namespace itproekt.ViewModels {
    public class ResultsViewModel {

        public List<Movie> MovieResults { get; set; }

        public List<Profile> UserResults { get; set; }

        public string Key { get; set; } 
    }
}
