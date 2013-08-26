using System;
using Persistence;
using Models;
namespace Persistence
{
    public interface IUnitOfWork
    {
        void Commit(bool shared);
        IRepositorioGenerico<tbl_modalidade> RepositorioModalidade { get; }
        IRepositorioGenerico<tbl_produto> RepositorioProduto { get; }
        IRepositorioGenerico<tbl_pessoa> RepositorioPessoa { get; }
        IRepositorioGenerico<tbl_aluno> RepositorioAluno { get; }
        IRepositorioGenerico<tbl_funcionario> RepositorioFuncionario { get; }
      //  IRepositorioGenerico<tbl_pagamento_mensalidade> RepositorioPagamentoMensalidade { get; }
    }
}
