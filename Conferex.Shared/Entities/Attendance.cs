using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conferex.Shared.Entities
{
    public class Attendance
    {

        public int Id { get; set; }


        [Display(Name = "Número de registro")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NumberConf { get; set; }


        [Display(Name = "Fecha de registro")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public DateTime DateConf { get; set; }


    }
}
