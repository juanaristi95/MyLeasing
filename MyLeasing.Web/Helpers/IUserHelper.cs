using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Helpers
{
    // Nota: Todo lo que tenga que ver con usuarios lo vamos a manejar
    // en esta interfaz.
    public interface IUserHelper
    {
        // Obtenermos el usuario mandando el e-mauil
        Task<User> GetUserByEmailAsync(string email);
        // Adicionamos un usuario mandando el usuario y contraseña
        // usuario = e-mail
        Task<IdentityResult> AddUserAsync(User user, string password);
        // chekea si existe un role de usuario
        Task CheckRoleAsync(string roleName);
        // Mandamos usuario y role y le decimos que me le asigne el role
        // al suario.
        Task AddUserToRoleAsync(User user, string roleName);
        // Preguntamos a que role pertenece un usuario
        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}
