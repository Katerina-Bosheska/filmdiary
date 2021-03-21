using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itproekt.Models {
    public class MovieActivity {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public virtual Profile Profile { get; set; }

        public virtual Movie Movie { get; set; }

        //watched, likes etc.
        public string Action { get; set; }
    }
}
