using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class Medida : Aluno
    {
        public int CodigoMedida { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "data", ResourceType = typeof(Mensagem))]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "altura", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Altura { get; set; }

        [Required]
        [Display(Name = "peso", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Peso { get; set; }

        [Required]
        [Display(Name = "imc", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal IMC { get; set; }

        [Required]
        [Display(Name = "gordura", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Gordura { get; set; }

        [Required]
        [Display(Name = "abdomen", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Abdomen { get; set; }

        [Required]
        [Display(Name = "cintura", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Cintura { get; set; }

        [Required]
        [Display(Name = "costa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Costa { get; set; }

        [Required]
        [Display(Name = "peitoral", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Peitoral { get; set; }

        [Required]
        [Display(Name = "quadril", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Quadril { get; set; }

        [Required]
        [Display(Name = "ombro", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal Ombro { get; set; }

        [Required]
        [Display(Name = "biceps_esquerdo", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal BicepsEsq { get; set; }

        [Required]
        [Display(Name = "biceps_direito", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal BicepsDir { get; set; }

        [Required]
        [Display(Name = "ante_braco_esquerdo", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal AnteBracoEsq { get; set; }

        [Required]
        [Display(Name = "ante_braco_direito", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal AnteBracoDir { get; set; }

        [Required]
        [Display(Name = "coxa_esquerda", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal CoxaEsq { get; set; }

        [Required]
        [Display(Name = "coxa_direita", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal CoxaDir { get; set; }

        [Required]
        [Display(Name = "panturrilha_esquerdo", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal PanturrilhaEsq { get; set; }

        [Required]
        [Display(Name = "panturrilha_direita", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public decimal PanturrilhaDir { get; set; }
    }
}
