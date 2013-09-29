using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorMatricula
    {

        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorMatricula()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorMatricula(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="matriculaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Matricula matriculaModel)
        {
            tbl_matricula matriculaE = new tbl_matricula();
            Atribuir(matriculaModel, matriculaE);
            unitOfWork.RepositorioMatricula.Inserir(matriculaE);
            unitOfWork.Commit(shared);
            return matriculaE.CodigoMatricula;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="matriculaModel"></param>
        public void Editar(Matricula matriculaModel)
        {
            tbl_matricula matriculaE = new tbl_matricula();
            Atribuir(matriculaModel, matriculaE);
            unitOfWork.RepositorioMatricula.Editar(matriculaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="matriculaModel"></param>
        public void Remover(int idMatricula)
        {
            unitOfWork.RepositorioMatricula.Remover(matricula => matricula.CodigoMatricula.Equals(idMatricula));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do matricula como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Matricula> GetQuery()
        {

            IQueryable<tbl_matricula> tbl_matricula = unitOfWork.RepositorioMatricula.GetQueryable();

            var query = from matricula in tbl_matricula                        
                        select new Matricula
                        {
                            CodigoMatricula = matricula.CodigoMatricula,
                            MatriculaAluno = matricula.MatriculaAluno,
                            CodigoModalidade = matricula.CodigoModalidade,
                            NomeAluno = matricula.tbl_aluno.tbl_pessoa.NomeRazao,
                            DataMatricula = matricula.DataMatricula,
                            NomeModalidade = matricula.tbl_modalidade.NomeModalidade
                        };

            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Matricula> ObterTodos()
        {
            return GetQuery();
        }




        /// <summary>
        /// Obter todas as modalidades que o aluno não está matriculado
        /// </summary>
        /// <param name="idMatricula">Identificador do aluno na base de dados</param>
        /// <returns></returns>
        public IEnumerable<Matricula> ObterTodasModalidadesAluno(int idMatricula)
        {
            return GetQuery().Where(matriculaModel => matriculaModel.MatriculaAluno.Equals(idMatricula));
        }

        /// <summary>
        /// Obtém um matricula
        /// </summary>
        /// <param name="idMatricula">Identificador do matricula na base de dados</param>
        /// <returns>Matricula model</returns>
        public Matricula Obter(int idMatricula)
        {
            IEnumerable<Matricula> matriculaes = GetQuery().Where(matriculaModel => matriculaModel.CodigoMatricula.Equals(idMatricula));
            return matriculaes.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Matricula Model para o Matricula Entity
        /// </summary>
        /// <param name="matriculaModel">Objeto do modelo</param>
        /// <param name="matriculaE">Entity mapeada da base de dados</param>
        private void Atribuir(Matricula matriculaModel, tbl_matricula matriculaE)
        {
            matriculaE.CodigoMatricula = matriculaModel.CodigoMatricula;
            matriculaE.MatriculaAluno = matriculaModel.MatriculaAluno;
            matriculaE.CodigoModalidade = matriculaModel.CodigoModalidade;
            matriculaE.DataMatricula = matriculaModel.DataMatricula;
           
        }

    }

}
