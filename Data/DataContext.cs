using _2TDSPG_Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _2TDSPG_Cinema.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Ingresso> Ingressos { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }

        public DbSet<Reserva> Reservas { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=oracle.fiap.com.br:1521/orcl;User ID=rm99708;Password=180105");
        }


    }
}
