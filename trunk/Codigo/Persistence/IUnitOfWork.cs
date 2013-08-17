using System;
using Persistence;
using Models;
namespace Persistence
{
    public interface IUnitOfWork
    {
        void Commit(bool shared);
        IRepositorioGenerico<tbl_modalidade> RepositorioModalidade { get; }
       // IRepositorioGenerico<tb_editora> RepositorioEditora { get; }
       // IRepositorioGenerico<tb_livro> RepositorioLivro { get; }
    }
}
