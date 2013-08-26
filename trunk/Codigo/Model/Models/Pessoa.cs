using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class Pessoa
    {
        public int CodigoPessoa { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "cadastrado_desde", ResourceType = typeof(Mensagem))]
        public DateTime CadastradoDesde { get; set; }

        [Required]
        [Display(Name = "nome_razao", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomeRazao { get; set; }

        [Required]
        [Display(Name = "apelido", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string ApelidoFantasia { get; set; }

        [Required]
        [Display(Name = "cpf_cnpj", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string CpfCnpj { get; set; }

        [Required]
        [Display(Name = "rg", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string RG { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "data_nascimento", ResourceType = typeof(Mensagem))]
        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        [Required]
        [Display(Name = "rua", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Rua { get; set; }

        [Required]
        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Numero { get; set; }

        [Required]
        [Display(Name = "bairro", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Bairro { get; set; }

        [Required]
        [Display(Name = "cidade", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "estado", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Estado { get; set; }

        [Required]
        [Display(Name = "cep", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public int CEP { get; set; }

        [Required]
        [Display(Name = "complemento", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Complemento { get; set; }

        [Required]
        [Display(Name = "telefone1", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Telefone1 { get; set; }

        [Required]
        [Display(Name = "telefone2", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Telefone2 { get; set; }

        [Required]
        [Display(Name = "email", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "senha", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Senha { get; set; }
       
            
            
            
    }
}
