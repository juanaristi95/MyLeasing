using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Lessee
    {
        // propiedades - campos de la tabla Lessee
        public int Id { get; set; }

        public User User { get; set; }


        // Relaciones con otras tablas
        public ICollection<Contract> Contracts { get; set; }

    }
}
