using login.Models;
using Microsoft.EntityFrameworkCore;

namespace login.Data
{
    public class BancoContext: DbContext
    {

        public BancoContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
}
}
