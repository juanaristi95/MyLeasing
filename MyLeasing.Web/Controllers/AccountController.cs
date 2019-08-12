using Microsoft.AspNetCore.Mvc;
using MyLeasing.Web.Helpers;
using MyLeasing.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;
        // Inyectamos en IsurHelpers en nuestro constructor
        public AccountController(IUserHelper userHelper)
        {
            _userHelper = userHelper;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // Le enviamos el modelo del Login y recibimos una accion como resultado.
        // 
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // declaro una variable que me guarda el resultado de mi logeo
                var result = await _userHelper.LoginAsync(model);
                // si el logueo es exitoso, lo redirecciono
                if (result.Succeeded)
                {
                    // si tiene direccion de retorno me voy a esa direccion, 
                    // sino me voy al index.
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Failed to login.");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
