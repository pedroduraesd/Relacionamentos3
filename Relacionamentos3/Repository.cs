using System;
using Microsoft.EntityFrameworkCore;

namespace Relacionamentos3
{
    public class Repository : DbContext
    {
        private static readonly String _connectionParams = @"server=127.0.0.1;port=3307;uid=root;pwd=;database=predo";

        public Repository()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }
    }
}
