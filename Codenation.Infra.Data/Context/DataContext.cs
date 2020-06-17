using Codenation.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codenation.Infra.Data.Context
{
    public sealed class DataContext : DbContext, IDisposable
    {
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Marca>()
                        .ToTable("Marca");

            modelbuilder.Entity<Marca>()
                        .Property(c => c.Nome)
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Nome");

            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Versao>()
                        .ToTable("Versao");

            modelbuilder.Entity<Versao>()
                        .Property(c => c.Nome)
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Nome");

           base.OnModelCreating(modelbuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\sqlExpress;Initial Catalog=carro;Integrated Security=True");
            }

            // Comandos para criar primeira migração (para lembrar depois)
            // Exibir -> Console do Gerenciador de Pacotes 
            // Colocar projeto padrão (set as startup project): Infra.Data
            // rodar add-migration CriacaoTabelaMarca
            // update-database
            // rodar add-migration CriacaoTabelaVersao
            // update-database

            base.OnConfiguring(optionsBuilder);
        }
    }
}
