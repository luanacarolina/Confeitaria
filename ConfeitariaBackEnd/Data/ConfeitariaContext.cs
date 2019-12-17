using ConfeitariaBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfeitariaBackEnd.Data
{
    public class ConfeitariaContext : DbContext
    {
        public ConfeitariaContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Usuario>().ToTable("Tb_Usuario");
            builder.Entity<Produto>().ToTable("Tb_Produto");
            builder.Entity<Venda>().ToTable("Tb_Venda");
            builder.Entity<Ingrediente>().ToTable("Tb_Ingrediente");
        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}