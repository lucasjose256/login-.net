using login.Models;
using login.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace login.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio= usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Entrar(LoginModel loginModel) {
            try {
            
                if(ModelState.IsValid) {

                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);
                    if (usuario != null)
                    {
                        if (usuario.Senha==loginModel.Senha)
                        {
                            return RedirectToAction("Index", "Home");

                        }
                    }

                }
                return View("Index");

            }catch (Exception ex)
            {
                return RedirectToAction("Index");

                //trater erro com temp data, q mostra na tela como um alert
            }

        }
    }
}
