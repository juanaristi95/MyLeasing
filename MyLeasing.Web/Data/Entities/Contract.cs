using System;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Contract
    {
        // propiedades - campos de la tabla Contract
        public int Id { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Remarks { get; set; }
        // 
        [Display(Name = "Price")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Start Date*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; }

        // Relaciones con otras tablas
        public Property Property { get; set; }

        public Owner Owner { get; set; }

        public Lessee Lessee { get; set; }

        // mas propiedades
        [Display(Name = "Start Date*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDateLocal => StartDate.ToLocalTime();

        // ApplyFormatEdit - significa que cuando este editando
        // me de formato de fecha.
        // DateFormatString - le asigno un formato a la fecha.
        // ToLocalTime - resta la hora dependiendo del pais donde se muestra app
        [Display(Name = "End Date*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDateLocal => EndDate.ToLocalTime();
    }
}

