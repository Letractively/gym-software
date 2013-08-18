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
                if (_repProduto == null) {
                    _repProduto = new RepositorioGenerico<tbl_modalidade>(_context);
                }
                return _repProduto;
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
