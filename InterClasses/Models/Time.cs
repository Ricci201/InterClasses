using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Time
    {
        public int TimeId { get; set; } // Chave Primária (Id)

        [Required(ErrorMessage = "O campo Nome do Time é Obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do Time pode ter, no máximo, 50 caracteres")]
        public string? Nome { get; set; }

        // Relacionando entre Models (Tabelas no Banco de Dados)
        // Chave Estrangeira
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; } // Vincular o campo do Id da tabela
        public Esporte? Esporte { get; set; } // Vincular o Obejto relacionado ao Id acima

    }
}
