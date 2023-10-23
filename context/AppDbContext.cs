using Microsoft.EntityFrameworkCore;
using AAAAA_FUNCIONA_MDS.Models;

namespace App.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}