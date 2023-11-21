using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Conferex.Shared.Entities
{
    public class Sponsor
    {

        public int Id { get; set; }


        [Display(Name = "Nombre del patrocinador")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NamePatro { get; set; }


        [Display(Name = "Nivel del patrocinador")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ScalePatro { get; set; }



        [Display(Name = "Foto")]
        public string Photo { get; set; }
    }
}
