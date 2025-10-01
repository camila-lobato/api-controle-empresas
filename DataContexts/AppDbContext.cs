using Microsoft.EntityFrameworkCore;
using AtividadeAPI.Models;

namespace AtividadeAPI.DataContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Empresa> Empresas { get; set; }
    }
}
