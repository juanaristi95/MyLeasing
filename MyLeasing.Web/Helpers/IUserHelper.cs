using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyLeasing.Web.Data.Entities;
using MyLeasing.Web.Models;

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

        // Metodos para login/logout.
        // enviamos el modelo y me devueleve un SignInResult que me 
        //dice si me pude o no loguear.
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        // metodo para eliminar usuarios
       Task<bool> DeleteUserAsync(string email);

        // metodo para actualizar usuarios
        Task<IdentityResult> UpdateUserAsync(User user);

        // Verifico que la combinacion de usuario y contraseña sean validos.
        Task<SignInResult> ValidatePasswordAsync(User user, string password);

    }
}
