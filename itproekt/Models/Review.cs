using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace itproekt.Models {
    public class Review {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Review cannot be empty")]
        public string ReviewText { get; set; }

        public string Rating { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Profile Writer { get; set; }

        public int Likes { get; set; }
    }
}
