﻿using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Esporte
    {
        public int EsporteId { get; set; }

        [Required(ErrorMessage = "O Nome do Esporte é Obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do Esporte pode ter, no máximo, 50 caracteres")]
        [Display(Name = "Nome do Esporte")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade máxima de Jogadores por Time.")]
        [Range(1, 25, ErrorMessage = "O numero de jogadores deve estar entre 1 e 25.")]
        [Display(Name = "Quantidade de Jogadores")]
        public int QtdJogadores { get; set; }
    }
}
