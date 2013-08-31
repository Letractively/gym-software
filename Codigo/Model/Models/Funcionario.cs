using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class Funcionario : Pessoa
    {
        [Display(Name = "codigo_funcionario", ResourceType = typeof(Mensagem))]
        public int CodigoFuncionario { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_nome")]
        [Display(Name = "permicao", ResourceType = typeof(Mensagem))]
        public string Permicao { get; set; }
    }    
}
