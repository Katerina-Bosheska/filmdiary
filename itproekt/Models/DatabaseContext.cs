using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace itproekt.Models {
    public class DatabaseContext : DbContext {

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActivity> Activities { get; set; }
        public DbSet<Review> Reviews{ get; set; }
    }
}
