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

            modelbuilder.Entity<Veiculo>()
                   .ToTable("Veiculo");

            modelbuilder.Entity<Veiculo>()
                .Property(c => c.Imagem)
                .IsRequired()
                .HasColumnType("varchar(500)")
                .HasColumnName("Imagem");

            modelbuilder.Entity<Veiculo>()
                .Property(c => c.KM)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("KM");

            modelbuilder.Entity<Veiculo>()
                .Property(c => c.Preco)
                .IsRequired()
                .HasColumnType("float")
                .HasColumnName("Preco");

            modelbuilder.Entity<Veiculo>()
                .Property(c => c.AnoModelo)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("AnoModelo");

            modelbuilder.Entity<Veiculo>()
                .Property(c => c.AnoFabricacao)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("AnoFabricacao");

            modelbuilder.Entity<Veiculo>()
                .Property(c => c.Cor)
                .IsRequired()
                .HasColumnType("varchar(500)")
                .HasColumnName("Cor");

            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<Carro>()
                   .ToTable("Carro");

            modelbuilder.Entity<Carro>()
                .Property(c => c.Ano)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Ano");

            modelbuilder.Entity<Carro>()
                .Property(c => c.Quilometragem)
                .IsRequired()
                .HasColumnType("int")
                .HasColumnName("Quilometragem");

            modelbuilder.Entity<Carro>()
                .Property(c => c.Observacao)
                .IsRequired()
                .HasColumnType("varchar(500)")
                .HasColumnName("Observacao");

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
            // remove-migration (remove a última)

            base.OnConfiguring(optionsBuilder);
        }
    }
}
