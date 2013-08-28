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
        private GerenciadorPessoa gPessoa;
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAluno()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
            gPessoa = new GerenciadorPessoa(unitOfWork);
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


            alunoModel.CadastradoDesde = DateTime.Now;
            alunoModel.Fornecedor = "N";

            int codigoPessoa = gPessoa.Inserir(alunoModel);
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
            gPessoa.Editar(alunoModel);
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
            IQueryable<tbl_pessoa> tbl_pessoa = unitOfWork.RepositorioPessoa.GetQueryable();

            var query = from aluno in tbl_aluno
                        join pessoa in tbl_pessoa
                        on aluno.CodigoPessoa equals pessoa.CodigoPessoa

                        select new Aluno
                        {
                            Matricula = aluno.Matricula,
                            
                            
                            CodigoPessoa = aluno.CodigoPessoa,
                            ValorMensalidade = aluno.ValorMensalidade,
                            AtivoDesde = (DateTime) aluno.AtivoDesde,
                            DiaVencimento = aluno.DiaVencimento,
                            DataMatricula = (DateTime) aluno.DataMatricula,
                            DataTrancamento = (DateTime) aluno.DataTrancamento,

                            
                            ApelidoFantasia = pessoa.ApelidoFantasia,
                            Bairro = pessoa.Bairro,
                            CadastradoDesde = pessoa.CadastradoDesde,
                            CEP = pessoa.CEP,
                            Cidade = pessoa.Cidade,
                            Complemento = pessoa.Complemento,
                            CpfCnpj = pessoa.CpfCnpj,
                            DataNascimento = pessoa.DataNascimento,
                            Email = pessoa.Email,
                            Estado = pessoa.Estado,
                            NomeRazao = pessoa.NomeRazao,
                            Numero = pessoa.Numero,
                            RG = pessoa.RG,
                            Rua = pessoa.Rua,
                            Senha = pessoa.Senha,
                            Sexo = pessoa.Sexo,
                            Telefone1 = pessoa.Telefone1,
                            Telefone2 = pessoa.Telefone2,
                            Fornecedor = pessoa.Fornecedor

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
