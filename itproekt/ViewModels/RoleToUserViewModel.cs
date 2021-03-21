using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace itproekt.ViewModels {
    public class RoleToUserViewModel {


        [Required]
        public string RoleName { get; set; }

        [Required]
        public string Username { get; set; }

        public bool RemoveRoles { get; set; }
    }
}
