using Microsoft.EntityFrameworkCore;


namespace PedidosWeb.Models
{
    public class MeuDbContext : DbContext
    {
        internal object Users;

        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Produtos> Carrinho { get; set; }


    }
}

