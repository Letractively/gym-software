using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class Produto
    {       
        public int Codigo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_valor")]
        [Display(Name = "codigo_barra", ResourceType = typeof(Mensagem))]
        [StringLength(45, MinimumLength = 5)]        
        public string CodigoBarra { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_nome")]
        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        [StringLength(45, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        
        [Display(Name = "quantidade", ResourceType = typeof(Mensagem))]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]        
        [Display(Name = "quantidade_minima", ResourceType = typeof(Mensagem))]
        public decimal QuantidadeMinima { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "preco_custo", ResourceType = typeof(Mensagem))]
        public decimal PrecoCusto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "preco_venda", ResourceType = typeof(Mensagem))]
        public decimal PrecoVenda { get; set; }
   }
}
