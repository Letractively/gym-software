using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorAluno

    {

        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAluno()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorAluno(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="alunoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Aluno alunoModel)
        {
            tbl_aluno alunoE = new tbl_aluno();
            Atribuir(alunoModel, alunoE);
            unitOfWork.RepositorioAluno.Inserir(alunoE);
            unitOfWork.Commit(shared);
            return alunoE.Matricula;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="alunoModel"></param>
        public void Editar(Aluno alunoModel)
        {
            tbl_aluno alunoE = new tbl_aluno();
            Atribuir(alunoModel, alunoE);
            unitOfWork.RepositorioAluno.Editar(alunoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="alunoModel"></param>
        public void Remover(int idAluno)
        {
            unitOfWork.RepositorioAluno.Remover(aluno => aluno.Matricula.Equals(idAluno));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do aluno como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Aluno> GetQuery()
        {
            IQueryable<tbl_aluno> tbl_aluno = unitOfWork.RepositorioAluno.GetQueryable();
            var query = from aluno in tbl_aluno
                        select new Aluno
                        {
                            Matricula = aluno.Matricula,
                            CodigoPessoa = aluno.CodigoPessoa,
                            ValorMensalidade = aluno.ValorMensalidade,
                            AtivoDesde = aluno.AtivoDesde,
                            DiaVencimento = aluno.DiaVencimento,
                            DataMatricula = aluno.DataMatricula,
                            DataTrancamento = aluno.DataTrancamento


                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Aluno> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um aluno
        /// </summary>
        /// <param name="idAluno">Identificador do aluno na base de dados</param>
        /// <returns>Aluno model</returns>
        public Aluno Obter(int idAluno){
     
            IEnumerable<Aluno> alunoes = GetQuery().Where(alunoModel => alunoModel.Matricula.Equals(idAluno));
            return alunoes.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Aluno Model para o Aluno Entity
        /// </summary>
        /// <param name="alunoModel">Objeto do modelo</param>
        /// <param name="alunoE">Entity mapeada da base de dados</param>
        private void Atribuir(Aluno alunoModel, tbl_aluno alunoE)
        {

                            alunoE.Matricula = alunoModel.Matricula;
                            alunoE.CodigoPessoa = alunoModel.CodigoPessoa;
                            alunoE.ValorMensalidade = alunoModel.ValorMensalidade;
                            alunoE.AtivoDesde = alunoModel.AtivoDesde;
                            alunoE.DiaVencimento = alunoModel.DiaVencimento;
                            alunoE.DataMatricula = alunoModel.DataMatricula;
                            alunoE.DataTrancamento = alunoModel.DataTrancamento;
        }

    }

}
