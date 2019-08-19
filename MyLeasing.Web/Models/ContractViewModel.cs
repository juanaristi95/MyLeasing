using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Models
{
    public class ContractViewModel : Contract
    {
        // propiedades

        // me dice quien es el propietario de ese contrato
        public int OwnerId { get; set; }
        // Me dice cual es la propiedad
        public int PropertyId { get; set; }
        // cuando se selecciona el arrendatario en el Combo-Box
        // se selecciona el LesseId
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [Display(Name = "Lessee")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a Lessee")]
        public int LesseeId { get; set; }
        // armar el combo-box donde estarán todos los arrendatarios
        public IEnumerable<SelectListItem> Lessees { get; set; }
    }
}
