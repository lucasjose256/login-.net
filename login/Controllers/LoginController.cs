using login.Models;
using Microsoft.AspNetCore.Mvc;

namespace login.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Entrar(LoginModel login) {
            try {
            
                if(ModelState.IsValid) {

                    return RedirectToAction("Index", "Home");
                }
                return View("index");

            }catch (Exception ex)
            {
                return RedirectToAction("Index");

                //trater erro com temp data, q mostra na tela como um alert
            }

        }
    }
}
