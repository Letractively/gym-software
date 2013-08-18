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
        
        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Required]
        [StringLength(45)]
        public string CodigoBarra { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]        
        public decimal Valor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal QuantidadeMinima { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal PrecoCusto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "erro_valor")]
        [Range(0, 1000000)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal PrecoVenda { get; set; }
    }
}
