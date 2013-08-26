using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Models
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        //public int CodigoPessoa { get; set; }
        public decimal ValorMensalidade { get; set; }
        public DateTime AtivoDesde { get; set; }
        public DateTime DiaVencimento { get; set; }
        public DateTime DataMatricula { get; set; }
        public DateTime DataTrancamento { get; set; }    
    }
}
