﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;


namespace Models.Models
{
    public class Medida : Aluno
    {
        [Display(Name = "codigo_medida", ResourceType = typeof(Mensagem))]
        public int CodigoMedida { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "data_medida", ResourceType = typeof(Mensagem))]
        public DateTime Data { get; set; }
 
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "altura", ResourceType = typeof(Mensagem))]
        public decimal Altura { get; set; }
   
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "peso", ResourceType = typeof(Mensagem))]
        public decimal Peso { get; set; }       
 
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "imc", ResourceType = typeof(Mensagem))]
        public decimal IMC { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "gordura", ResourceType = typeof(Mensagem))]
        public decimal Gordura { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "abdomen", ResourceType = typeof(Mensagem))]
        public decimal Abdomen { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "cintura", ResourceType = typeof(Mensagem))]
        public decimal Cintura { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "costa", ResourceType = typeof(Mensagem))]
        public decimal Costa { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "peitoral", ResourceType = typeof(Mensagem))]
        public decimal Peitoral { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "quadril", ResourceType = typeof(Mensagem))]
        public decimal Quadril { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "ombro", ResourceType = typeof(Mensagem))]
        public decimal Ombro { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "biceps_esquerdo", ResourceType = typeof(Mensagem))]
        public decimal BicepsEsq { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "biceps_direito", ResourceType = typeof(Mensagem))]
        public decimal BicepsDir { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "ante_braco_esquerdo", ResourceType = typeof(Mensagem))]
        public decimal AnteBracoEsq { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "ante_braco_direito", ResourceType = typeof(Mensagem))]
        public decimal AnteBracoDir  { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "coxa_esquerda", ResourceType = typeof(Mensagem))]
        public decimal CoxaEsq { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "coxa_direita", ResourceType = typeof(Mensagem))]
        public decimal CoxaDir { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "panturrilha_esquerdo", ResourceType = typeof(Mensagem))]
        public decimal PanturrilhaEsq { get; set; }

        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "panturrilha_direita", ResourceType = typeof(Mensagem))]
        public decimal PanturrilhaDir { get; set; }                
    
   }
}
