using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Conferex.Shared.Entities
{
    public class Assistant
    {

        public int Id { get; set; }

        [Display(Name = "Documento del asistente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DocumentAsis { get; set; }


        [Display(Name = "Nombre del asistente")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameAsis { get; set; }


        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string EmailAsis { get; set; }


        [Display(Name = "Nombre de la organización a la que pertenece")]
        [MaxLength(60, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string OrganizationAsis { get; set; }
    }
}
