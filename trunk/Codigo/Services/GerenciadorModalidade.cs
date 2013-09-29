using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorModalidade
    {

          private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorModalidade()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorModalidade(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="modalidadeModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Modalidade modalidadeModel)
        {
            tbl_modalidade modalidadeE = new tbl_modalidade();
            Atribuir(modalidadeModel, modalidadeE);
            unitOfWork.RepositorioModalidade.Inserir(modalidadeE);
            unitOfWork.Commit(shared);
            return modalidadeE.CodigoModalidade;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="modalidadeModel"></param>
        public void Editar(Modalidade modalidadeModel)
        {
            tbl_modalidade modalidadeE = new tbl_modalidade(); 
            Atribuir(modalidadeModel, modalidadeE);
            unitOfWork.RepositorioModalidade.Editar(modalidadeE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="modalidadeModel"></param>
        public void Remover(int CodigoModalidade)
        {
            unitOfWork.RepositorioModalidade.Remover(modalidade => modalidade.CodigoModalidade.Equals(CodigoModalidade));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do modalidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Modalidade> GetQuery()
        {
            IQueryable<tbl_modalidade> tbl_modalidade = unitOfWork.RepositorioModalidade.GetQueryable();
            var query = from modalidade in tbl_modalidade 
                        select new Modalidade
                        {
                            Codigo = modalidade.CodigoModalidade,
                            Nome = modalidade.NomeModalidade,
                            Valor = modalidade.ValorModalidade
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Modalidade> ObterTodos()
        {
            return GetQuery();
        }




        /// <summary>
        /// Obtém um modalidade
        /// </summary>
        /// <param name="idModalidade">Identificador do modalidade na base de dados</param>
        /// <returns>Modalidade model</returns>
        public Modalidade Obter(int idModalidade)
        {
            IEnumerable<Modalidade> modalidadees = GetQuery().Where(modalidadeModel => modalidadeModel.Codigo.Equals(idModalidade));
            return modalidadees.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Modalidade Model para o Modalidade Entity
        /// </summary>
        /// <param name="modalidadeModel">Objeto do modelo</param>
        /// <param name="modalidadeE">Entity mapeada da base de dados</param>
        private void Atribuir(Modalidade modalidadeModel, tbl_modalidade modalidadeE)
        {
            modalidadeE.CodigoModalidade = modalidadeModel.Codigo;
            modalidadeE.NomeModalidade = modalidadeModel.Nome;
            modalidadeE.ValorModalidade = modalidadeModel.Valor;
        }

    }

}
