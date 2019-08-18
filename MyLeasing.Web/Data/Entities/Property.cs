using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Property
    {
        // propiedades - campos de la tabla Property
        public int Id { get; set; }

        [Display(Name = "Neighborhood")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Address")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Address { get; set; }

        [Display(Name = "Price*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Square meters*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int SquareMeters { get; set; }

        [Display(Name = "Rooms")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Rooms { get; set; }

        [Display(Name = "Stratum*")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Stratum { get; set; }

        [Display(Name = "Has Parking Lot?")]
        public bool HasParkingLot { get; set; }

        [Display(Name = "Is Available?")]
        public bool IsAvailable { get; set; }

        public string Remarks { get; set; }

        // Relaciones con otras tablas

        // Forma 1: creo propiedad de tipo propertyType donde esta
        // la relacion de muchos.
        // se podria colocar la forma 2(Icolelction) en property
        // y seria mucho mejor
        public PropertyType PropertyType { get; set; }

        // Aqui le digo que yo como propiedad pertenezco a un Owner
        public Owner Owner { get; set; }

        // Forma 2: Creo propiedad de tipo Icollection donde esta
        // la relacion de 1, la propiedad la llamo como la tabla
        // pero en plural.
        public ICollection<Contract> Contracts { get; set; }

        public ICollection<PropertyImage> PropertyImages { get; set; }

        // Note: si en las relaciones entre tablas se usan
        // la forma 1 y 2. es mucho mejor y facil para consultas.
    }
}

