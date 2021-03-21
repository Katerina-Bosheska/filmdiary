using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itproekt.Models {
    public class Profile {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Username { get; set; }

        public string Picture { get; set; }

        public string Bio { get; set; }

        public virtual List<string> FavoriteMovies { get; set; }

        public virtual List<Movie> Watched { get; set; }

        public virtual List<Movie> Liked { get; set; }

        public virtual List<Movie> Watchlist { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}
