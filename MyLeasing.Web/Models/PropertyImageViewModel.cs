using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using MyLeasing.Web.Data.Entities;


namespace MyLeasing.Web.Models
{
    public class PropertyImageViewModel : PropertyImage
    {

        // esta es la propiedad del archivo tipo imagen como tal
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
