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
        [Display(Name = "Código_Funcionario")]
        public int CodigoFuncionario { get; set; }

        [Required]
        [Display(Name = "permicao")]
        public string Permicao { get; set; }
    }    
}
