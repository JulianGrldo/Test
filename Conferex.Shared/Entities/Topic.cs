using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Conferex.Shared.Entities
{
    public class Topic
    {

        public int Id { get; set; }


        [Display(Name = "Título de la conferencia")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string TitleConfer { get; set; }


        [Display(Name = "Ponente de la conferencia")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string SpeakerConfer { get; set; }


        [DataType(DataType.MultilineText)]
        [Display(Name = "Descripción Conferencia")]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string DescriptionConf { get; set; } = null!;


        [Display(Name = "Horario de inicio")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ScheduleIni { get; set; }


        [Display(Name = "Horario de final")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string ScheduleFin { get; set; }
    }
}
