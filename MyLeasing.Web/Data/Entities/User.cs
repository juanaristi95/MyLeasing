using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    // Se hereda de un IdentityUser - que a su vez hereda de una interfaz
    // con campos de usuarios.
    public class User : IdentityUser
    {
        // Propiedades no heredadas de la clase User
        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string LastName { get; set; }

        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }
        // Propiedades de lectura
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
