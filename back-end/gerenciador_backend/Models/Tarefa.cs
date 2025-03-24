using System;
using System.ComponentModel.DataAnnotations;

namespace gerenciador_backend.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título é obrigatório")]
        [StringLength(100, ErrorMessage = "O título deve ter no máximo 100 caracteres")]
        public string Titulo { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "A data de criação é obrigatória")]
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "O status é obrigatório")]
        public StatusTarefa Status { get; set; } = StatusTarefa.Pendente;

        public DateTime? DataConclusao { get; set; }

        [Required(ErrorMessage = "A prioridade é obrigatória")]
        public PrioridadeTarefa Prioridade { get; set; } = PrioridadeTarefa.Media;
    }

    public enum StatusTarefa
    {
        Pendente,
        EmAndamento,
        Concluida,
        Cancelada
    }

    public enum PrioridadeTarefa
    {
        Baixa,
        Media,
        Alta,
        Urgente
    }
} 