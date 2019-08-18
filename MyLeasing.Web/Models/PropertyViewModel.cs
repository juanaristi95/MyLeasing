using Microsoft.AspNetCore.Mvc.Rendering;
using MyLeasing.Web.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Models
{
    // la propertyviewmodel hereda de la clase property
    public class PropertyViewModel : Property
    {
        // propeidades
        public int OwnerId { get; set; }

        // combo box - dropdonwlist
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Property Type")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a property Type.")]
        public int PropertyTypeId { get; set; }

        // aqui vamos a tener las opciones que el usuario ttiene para elegir,
        //pero será en la propiedad PropertyTypeId donde se alamacenara dicho valor.
        public IEnumerable<SelectListItem> PropertyTypes { get; set; }
    }
}
