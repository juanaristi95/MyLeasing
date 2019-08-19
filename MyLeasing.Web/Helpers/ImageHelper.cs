using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace MyLeasing.Web.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            // el guid me sirve para darl un nombre al archivo tipo jpg
            // y que este no se repita
            var guid = Guid.NewGuid().ToString();
            var file = $"{guid}.jpg";
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "wwwroot\\images\\Properties",
                file);

            // coje rl archivo, lo lee y lo sube al servidor
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }
            // ~(verbulilla) equivale a la ruta relativa de la imageny no
            // la ruta absoluta
            return $"~/images/Properties/{file}";
        }
    }
}

