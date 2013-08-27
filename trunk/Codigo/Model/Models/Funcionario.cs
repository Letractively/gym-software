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
        [Display(Name = "sexo", ResourceType = typeof(Mensagem))]
        public /*Permicao*/ string Permicao { get; set; }
    }

    public enum Permicao { Atendente, Instrutor, Proprietario };
}
