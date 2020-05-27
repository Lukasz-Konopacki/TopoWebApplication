using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Topo.Model;

namespace Topo.ViewModel
{
    public class IndexViewModel
    {
        public List<Region> Regions { get; set; }

        [Required(ErrorMessage = "pole wymagane")]
        [MinLength(6, ErrorMessage = "za krótki email")]
        [StringLength(30, ErrorMessage = "za długi email")]
        [EmailAddress(ErrorMessage = "błędny adress email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "pole wymagane")]
        [MinLength(6, ErrorMessage = "za krótkie hasło")]
        [StringLength(30, ErrorMessage = "za długie hasło")]
        public string Password { get; set; }
        [Required(ErrorMessage = "pole wymagane")]
        [Compare("Password", ErrorMessage = "Podane hasła się różnią")]
        public string RepPassword { get; set; }
    }
}
