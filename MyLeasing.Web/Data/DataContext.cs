using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    //Hereda de la clase DbContext
    public class DataContext : DbContext
    {
        // injectamos al constructor -> options
        // pasamos el cosntructo y le enviamos el mismo options a la clase heredada
        // Estamos creando conexion a BD 
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        // asignamos las tablas de la BD
        // aqui le decimos que coja el modelo Owner y lo covierta a una tabla Owners
        public DbSet<Owner> Owners { get; set; }

    }
}
