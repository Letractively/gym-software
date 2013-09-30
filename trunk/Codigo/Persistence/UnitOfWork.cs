﻿using System;
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
        private IRepositorioGenerico<tbl_medida> _repMedida;
        private IRepositorioGenerico<tbl_atividade> _repAtividade;
        private IRepositorioGenerico<tbl_matricula> _repMatricula;
        private IRepositorioGenerico<tbl_rotina> _repRotina;
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

        public IRepositorioGenerico<tbl_medida> RepositorioMedida
        {
            get
            {
                if (_repMedida == null)
                {
                    _repMedida = new RepositorioGenerico<tbl_medida>(_context);
                }
                return _repMedida;
            }
        }

        public IRepositorioGenerico<tbl_atividade> RepositorioAtividade
        {
            get
            {
                if (_repAtividade == null)
                {
                    _repAtividade = new RepositorioGenerico<tbl_atividade>(_context);
                }
                return _repAtividade;
            }
        }

        public IRepositorioGenerico<tbl_matricula> RepositorioMatricula
        {
            get
            {
                if (_repMatricula == null)
                {
                    _repMatricula = new RepositorioGenerico<tbl_matricula>(_context);
                }
                return _repMatricula;
            }
        }

        public IRepositorioGenerico<tbl_rotina> RepositorioRotina
        {
            get
            {
                if (_repRotina == null)
                {
                    _repRotina = new RepositorioGenerico<tbl_rotina>(_context);
                }
                return _repRotina;
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
