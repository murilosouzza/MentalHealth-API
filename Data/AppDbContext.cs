using MentalHealth_.Models;
using Microsoft.EntityFrameworkCore;

namespace MentalHealth_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Pesquisa> Pesquisas { get; set; }
    }
}