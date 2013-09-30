using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorAtividade
    {

        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAtividade()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorAtividade(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="atividadeModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Atividade atividadeModel)
        {
            tbl_atividade atividadeE = new tbl_atividade();
            Atribuir(atividadeModel, atividadeE);
            unitOfWork.RepositorioAtividade.Inserir(atividadeE);
            unitOfWork.Commit(shared);
            return atividadeE.CodigoAtividade;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="atividadeModel"></param>
        public void Editar(Atividade atividadeModel)
        {
            tbl_atividade atividadeE = new tbl_atividade();
            Atribuir(atividadeModel, atividadeE);
            unitOfWork.RepositorioAtividade.Editar(atividadeE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="atividadeModel"></param>
        public void Remover(int CodigoAtividade)
        {
            unitOfWork.RepositorioAtividade.Remover(atividade => atividade.CodigoAtividade.Equals(CodigoAtividade));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do atividade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Atividade> GetQuery()
        {

            IQueryable<tbl_atividade> tbl_atividade = unitOfWork.RepositorioAtividade.GetQueryable();
            IQueryable<tbl_modalidade> tbl_modalidade = unitOfWork.RepositorioModalidade.GetQueryable();
            var query = from atividade in tbl_atividade
                        join modalidade in tbl_modalidade
                        on atividade.CodigoModalidade equals modalidade.CodigoModalidade
                        select new Atividade
                        {
                            CodigoAtividade = atividade.CodigoAtividade,
                            CodigoModalidade = atividade.CodigoModalidade,
                            NomeAtividade = atividade.NomeAtividade,
                            NomeModalidade = atividade.tbl_modalidade.NomeModalidade
                        };

            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Atividade> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as entidades cadastradas de uma modalidade
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Atividade> ObterTodasAtividadesDaModalidade(int idModalidade)
        {
            return GetQuery().Where(atividadeModel => atividadeModel.CodigoModalidade.Equals(idModalidade));
        }

        /// <summary>
        /// Obtém um atividade
        /// </summary>
        /// <param name="idAtividade">Identificador do atividade na base de dados</param>
        /// <returns>Atividade model</returns>
        public Atividade Obter(int idAtividade)
        {
            IEnumerable<Atividade> atividadees = GetQuery().Where(atividadeModel => atividadeModel.CodigoAtividade.Equals(idAtividade));
            return atividadees.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Atividade Model para o Atividade Entity
        /// </summary>
        /// <param name="atividadeModel">Objeto do modelo</param>
        /// <param name="atividadeE">Entity mapeada da base de dados</param>
        private void Atribuir(Atividade atividadeModel, tbl_atividade atividadeE)
        {

            atividadeE.CodigoAtividade = atividadeModel.CodigoAtividade;
            atividadeE.CodigoModalidade = atividadeModel.CodigoModalidade;
            atividadeE.NomeAtividade = atividadeModel.NomeAtividade;
           
        }

    }

}
