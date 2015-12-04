using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using I18nMvc.Idiomas;

namespace I18nMvc.Models
{
    public class Persona
    {
        [Display(ResourceType = typeof(Personas), Name = "Nombre")]
        [Required(ErrorMessageResourceType = typeof(Personas), ErrorMessageResourceName = "nombre_o")]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(ResourceType = typeof(Personas), Name = "Saldo")]
        public double Saldo { get; set; }
    }
}
