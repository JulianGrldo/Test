using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Conferex.Shared.Entities
{
    public class Conference
    {

        public int Id { get; set; }


        [Display(Name = "Nombre de la conferencia")]
        [MaxLength(250, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameConf { get; set; }


        [Display(Name = "Fecha de la conferencia")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DateConf { get; set; }


        [Display(Name = "Dirección del lugar de la conferencia")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string AddresConf { get; set; }



        [Display(Name = "Capacidad máxima del lugar de la conferencia")]
        [MaxLength(200, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string SizeConf { get; set; }


        [Display(Name = "Costo de la inscripción a la conferencia")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string PriceConf { get; set; }
    }
}
