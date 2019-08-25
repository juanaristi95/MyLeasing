using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        // Propiedades
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must contain between {2} and {1} characters.")]
        public string Password { get; set; }

        [Display(Name = "Password Confirm")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.Password)]
        // le decimos que el maximo es de 20 y el minimo de 6
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The {0} field must contain between {2} and {1} characters.")]
        // verifica esta propiedad con la propiedad Paswword.
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
