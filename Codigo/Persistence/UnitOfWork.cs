using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Persistence;

namespace Persistence
{
    /// <summary>
    /// UnitWork é um padrão de projeto que permite trabalhar 
    /// com vários repositórios compartilhando um mesmo contexto
    /// transacional
    /// </summary>
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AcademiaEntities _context;
        private IRepositorioGenerico<tbl_modalidade> _repModalidade;
        private IRepositorioGenerico<tbl_produto> _repProduto;
        private IRepositorioGenerico<tbl_pessoa> _repPessoa;
        private IRepositorioGenerico<tbl_aluno> _repAluno;
        private IRepositorioGenerico<tbl_funcionario> _repFuncionario;
     //   private IRepositorioGenerico<tbl_pagamento_mensalidade> _repPagamentoMensalidade;
        /// <summary>
        /// Construtor cria contexto transacional
        /// </summary>
        public UnitOfWork()
        {
            _context = new Models.AcademiaEntities();
        }
        
        #region IUnitOfWork Members



        /// <summary>
        /// Repositório para manipular dados persistidos de modalidadees
        /// </summary>
        public IRepositorioGenerico<tbl_modalidade> RepositorioModalidade { 
            get
            {
                if (_repModalidade == null) {
                    _repModalidade = new RepositorioGenerico<tbl_modalidade>(_context);
                }
                return _repModalidade;
            }
        }

        public IRepositorioGenerico<tbl_produto> RepositorioProduto
        {
            get
            {
                if (_repProduto == null)
                {
                    _repProduto = new RepositorioGenerico<tbl_produto>(_context);
                }
                return _repProduto;
            }
        }


        public IRepositorioGenerico<tbl_pessoa> RepositorioPessoa
        {
            get
            {
                if (_repPessoa == null)
                {
                    _repPessoa = new RepositorioGenerico<tbl_pessoa>(_context);
                }
                return _repPessoa;
            }
        }

        public IRepositorioGenerico<tbl_aluno> RepositorioAluno
        {
            get
            {
                if (_repAluno == null)
                {
                    _repAluno = new RepositorioGenerico<tbl_aluno>(_context);
                }
                return _repAluno;
            }
        }

        public IRepositorioGenerico<tbl_funcionario> RepositorioFuncionario
        {
            get
            {
                if (_repFuncionario == null)
                {
                    _repFuncionario = new RepositorioGenerico<tbl_funcionario>(_context);
                }
                return _repFuncionario;
            }
        }

    
        /// <summary>
        /// Salva todas as mudanças realizadas no contexto
        /// quando o contexto não for compartilhado
        /// </summary>
        public void Commit(bool shared)
        {
            if (!shared)
                _context.SaveChanges();
        }

        #endregion

        private bool disposed = false;
        /// <summary>
        /// Retira da memória um determinado contexto
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Limpa contexto da memória
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
