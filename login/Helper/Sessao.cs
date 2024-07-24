using login.Models;
using Newtonsoft.Json;

namespace login.Helper
{
    public class Sessao : ISessao
    {

        private readonly IHttpContextAccessor _contextAccessor;


        public Sessao(IHttpContextAccessor httpContext)
        {
            _contextAccessor = httpContext;
        }
        public UsuarioModel BuscarSessaoDoUsuario()
        {

        }

        public void CriarSessausuario(UsuarioModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);
            _contextAccessor.HttpContext.Session.Set("sessaoUsuarioLogado",);
        }

        public void RemoverSessaoUsuario()
        {
            throw new NotImplementedException();
        }
    }
}
