using System;
using Microsoft.EntityFrameworkCore;
using gerenciador_backend.Models;

namespace gerenciador_backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais de modelo podem ser adicionadas aqui
            
            // Exemplo de dados iniciais (seed) com data fixa
            modelBuilder.Entity<Tarefa>().HasData(
                new Tarefa
                {
                    Id = 1,
                    Titulo = "Implementar API de Tarefas",
                    Descricao = "Criar uma API CRUD para gerenciamento de tarefas",
                    DataCriacao = new DateTime(2023, 3, 25, 0, 0, 0, DateTimeKind.Utc),
                    Status = StatusTarefa.EmAndamento,
                    Prioridade = PrioridadeTarefa.Alta
                }
            );
        }
    }
} 