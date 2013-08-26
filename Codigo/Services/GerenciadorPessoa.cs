using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorPessoa
    {

        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPessoa()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorPessoa(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="pessoaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Pessoa pessoaModel)
        {
            tbl_pessoa pessoaE = new tbl_pessoa();
            Atribuir(pessoaModel, pessoaE);
            unitOfWork.RepositorioPessoa.Inserir(pessoaE);
            unitOfWork.Commit(shared);
            return pessoaE.CodigoPessoa;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="pessoaModel"></param>
        public void Editar(Pessoa pessoaModel)
        {
            tbl_pessoa pessoaE = new tbl_pessoa();
            Atribuir(pessoaModel, pessoaE);
            unitOfWork.RepositorioPessoa.Editar(pessoaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="pessoaModel"></param>
        public void Remover(int CodigoPessoa)
        {
            unitOfWork.RepositorioPessoa.Remover(pessoa => pessoa.CodigoPessoa.Equals(CodigoPessoa));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do pessoa como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Pessoa> GetQuery()
        {
            IQueryable<tbl_pessoa> tbl_pessoa = unitOfWork.RepositorioPessoa.GetQueryable();
            var query = from pessoa in tbl_pessoa
                        select new Pessoa
                        {
                            CodigoPessoa = pessoa.CodigoPessoa,
                            CadastradoDesde = pessoa.CadastradoDesde,
                            NomeRazao = pessoa.NomeRazao,
                            ApelidoFantasia = pessoa.ApelidoFantasia,
                            CpfCnpj = pessoa.CpfCnpj,
                            RG = pessoa.RG,
                            DataNascimento = pessoa.DataNascimento,
                            Sexo = pessoa.Sexo,
                            Rua = pessoa.Rua,
                            Numero = pessoa.Numero,
                            Bairro = pessoa.Bairro,
                            Cidade = pessoa.Cidade,
                            Estado = pessoa.Estado,
                            CEP = pessoa.CEP,
                            Complemento = pessoa.Complemento,
                            Telefone1 = pessoa.Telefone1,
                            Telefone2 = pessoa.Telefone2,
                            Email = pessoa.Email,
                            Senha = pessoa.Senha


                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pessoa> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pessoa
        /// </summary>
        /// <param name="idPessoa">Identificador do pessoa na base de dados</param>
        /// <returns>Pessoa model</returns>
        public Pessoa Obter(int idPessoa)
        {
            IEnumerable<Pessoa> pessoaes = GetQuery().Where(pessoaModel => pessoaModel.CodigoPessoa.Equals(idPessoa));
            return pessoaes.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Pessoa Model para o Pessoa Entity
        /// </summary>
        /// <param name="pessoaModel">Objeto do modelo</param>
        /// <param name="pessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(Pessoa pessoaModel, tbl_pessoa pessoaE)
        {

            pessoaE.CodigoPessoa = pessoaModel.CodigoPessoa;
            pessoaE.CadastradoDesde = pessoaModel.CadastradoDesde;
            pessoaE.NomeRazao = pessoaModel.NomeRazao;
            pessoaE.ApelidoFantasia = pessoaModel.ApelidoFantasia;
            pessoaE.CpfCnpj = pessoaModel.CpfCnpj;
            pessoaE.RG = pessoaModel.RG;
            pessoaE.DataNascimento = pessoaModel.DataNascimento;
            pessoaE.Sexo = pessoaModel.Sexo;
            pessoaE.Rua = pessoaModel.Rua;
            pessoaE.Numero = pessoaModel.Numero;
            pessoaE.Bairro = pessoaModel.Bairro;
            pessoaE.Cidade = pessoaModel.Cidade;
            pessoaE.Estado = pessoaModel.Estado;
            pessoaE.CEP = pessoaModel.CEP;
            pessoaE.Complemento = pessoaModel.Complemento;
            pessoaE.Telefone1 = pessoaModel.Telefone1;
            pessoaE.Telefone2 = pessoaModel.Telefone2;
            pessoaE.Email = pessoaModel.Email;
            pessoaE.Senha = pessoaModel.Senha;
        }

    }

}
