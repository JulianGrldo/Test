using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Conferex.Shared.Entities
{
    public class Organizer
    {

        public int Id { get; set; }

        [Display(Name = "Nombre del organizador")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameOrga { get; set; }


        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string EmailOrga { get; set; }
    }
}
