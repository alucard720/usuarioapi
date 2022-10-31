

using Microsoft.EntityFrameworkCore;

namespace UsuariosApi.Models
{
    public class UsuarioContext : DbContext
    
    
    {

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options){}

        public DbSet<Usuarios> flutterlogin {get; set;}
    }

}