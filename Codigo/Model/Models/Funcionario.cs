using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class Funcionario
    {
        [Display(Name = "Código")]
        public int CodigoFuncionario { get; set; }
        
        [Required]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_valor")]
        public Permicao Permicao { get; set; }
    }

    public enum Permicao
    {
        Atendente, Instrutor, Proprietario
    }
}
