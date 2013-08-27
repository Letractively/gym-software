using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class Aluno : Pessoa
    {

        [Display(Name = "matricula", ResourceType = typeof(Mensagem))]
        public int Matricula { get; set; }


        
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "valor_mensalidade", ResourceType = typeof(Mensagem))]
        public decimal ValorMensalidade { get; set; }


        
        [DataType(DataType.Date)]
        [Display(Name = "ativo_desde", ResourceType = typeof(Mensagem))]
        public DateTime AtivoDesde { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "dia_vencimento", ResourceType = typeof(Mensagem))]
        public DateTime DiaVencimento { get; set; }

        
        [DataType(DataType.Date)]
        [Display(Name = "data_matricula", ResourceType = typeof(Mensagem))]
        public DateTime DataMatricula { get; set; }

        
        [DataType(DataType.Date)]
        [Display(Name = "data_trancamento", ResourceType = typeof(Mensagem))]
        public DateTime DataTrancamento { get; set; }




    }
}
