using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class Atividade
    {

        [Display(Name = "cod_atividade", ResourceType = typeof(Mensagem))]
        public int CodigoAtividade { get; set; }

        [Display(Name = "cod_modalidade", ResourceType = typeof(Mensagem))]
        public int CodigoModalidade { get; set; }

        [Required]
        [Display(Name = "nome_atividade", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        public string NomeAtividade { get; set; }

        [Display(Name = "modalidade", ResourceType = typeof(Mensagem))]
        public string NomeModalidade { get; set; }

    }
}
