using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{

 public class Matricula
    {



     [Display(Name = "cod_matricula", ResourceType = typeof(Mensagem))]
     public int CodigoMatricula { get; set; }
        
        [Display(Name = "matricula", ResourceType = typeof(Mensagem))]
        public int MatriculaAluno { get; set; }


        [Display(Name = "cod_modalidade", ResourceType = typeof(Mensagem))]
        public int CodigoModalidade { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "data_matricula", ResourceType = typeof(Mensagem))]
        public DateTime DataMatricula { get; set; }

        [Display(Name = "nome_modalidade", ResourceType = typeof(Mensagem))]
        public string NomeModalidade { get; set; }

        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        public string NomeAluno { get; set; }

    }    
}
