using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorFuncionario
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorFuncionario()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorFuncionario(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="funcionarioModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Funcionario funcionarioModel)
        {
            tbl_funcionario funcionarioE = new tbl_funcionario();
            Atribuir(funcionarioModel, funcionarioE);
            unitOfWork.RepositorioFuncionario.Inserir(funcionarioE);
            unitOfWork.Commit(shared);
            return funcionarioE.CodigoFuncionario;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="funcionarioModel"></param>
        public void Editar(Funcionario funcionarioModel)
        {
            tbl_funcionario funcionarioE = new tbl_funcionario(); 
            Atribuir(funcionarioModel, funcionarioE);
            unitOfWork.RepositorioFuncionario.Editar(funcionarioE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="funcionarioModel"></param>
        public void Remover(int CodigoFuncionario)
        {
            unitOfWork.RepositorioFuncionario.Remover(funcionario => funcionario.CodigoFuncionario.Equals(CodigoFuncionario));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do funcionario como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Funcionario> GetQuery()
        {
            IQueryable<tbl_funcionario> tbl_funcionario = unitOfWork.RepositorioFuncionario.GetQueryable();
            var query = from funcionario in tbl_funcionario 
                        select new Funcionario
                        {
                            CodigoFuncionario = funcionario.CodigoFuncionario,
                            Permicao = funcionario.Permicao
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Funcionario> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um funcionario
        /// </summary>
        /// <param name="idFuncionario">Identificador do funcionario na base de dados</param>
        /// <returns>Funcionario model</returns>
        public Funcionario Obter(int idFuncionario)
        {
            IEnumerable<Funcionario> funcionarioes = GetQuery().Where(funcionarioModel => funcionarioModel.CodigoFuncionario.Equals(idFuncionario));
            return funcionarioes.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Funcionario Model para o Funcionario Entity
        /// </summary>
        /// <param name="funcionarioModel">Objeto do modelo</param>
        /// <param name="funcionarioE">Entity mapeada da base de dados</param>
        private void Atribuir(Funcionario funcionarioModel, tbl_funcionario funcionarioE)
        {    
            funcionarioE.CodigoFuncionario = funcionarioModel.CodigoFuncionario;            
            funcionarioE.Permicao = funcionarioModel.Permicao; 
        }
    }
}
