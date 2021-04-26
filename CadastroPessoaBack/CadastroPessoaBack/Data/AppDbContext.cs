using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPessoaBack.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(p => p.Nome)
                    .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .Property(p => p.Cpf)
                    .HasMaxLength(11)
                        .IsRequired();

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.Enderecos)
                    .WithOne();
        }
    }
}
