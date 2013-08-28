using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorProduto
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorProduto()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorProduto(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="produtoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Produto produtoModel)
        {
            tbl_produto produtoE = new tbl_produto();
            Atribuir(produtoModel, produtoE);
            unitOfWork.RepositorioProduto.Inserir(produtoE);
            unitOfWork.Commit(shared);
            return produtoE.CodigoProduto;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="produtoModel"></param>
        public void Editar(Produto produtoModel)
        {
            tbl_produto produtoE = new tbl_produto(); 
            Atribuir(produtoModel, produtoE);
            unitOfWork.RepositorioProduto.Editar(produtoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="produtoModel"></param>
        public void Remover(int CodigoProduto)
        {
            unitOfWork.RepositorioProduto.Remover(produto => produto.CodigoProduto.Equals(CodigoProduto));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do produto como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Produto> GetQuery()
        {
            IQueryable<tbl_produto> tbl_produto = unitOfWork.RepositorioProduto.GetQueryable();
            var query = from produto in tbl_produto 
                        select new Produto
                        {
                            Codigo = produto.CodigoProduto,
                            CodigoBarra = produto.CodigoBarra,
                            Nome = produto.NomeItem,
                            Quantidade = produto.Quantidade,                         
                            QuantidadeMinima = produto.QuantidadeMinima,
                            PrecoCusto = produto.PrecoCusto,
                            PrecoVenda = produto.PrecoVenda
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Produto> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um produto
        /// </summary>
        /// <param name="idProduto">Identificador do produto na base de dados</param>
        /// <returns>Produto model</returns>
        public Produto Obter(int idProduto)
        {
            IEnumerable<Produto> produtoes = GetQuery().Where(produtoModel => produtoModel.Codigo.Equals(idProduto));
            return produtoes.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Produto Model para o Produto Entity
        /// </summary>
        /// <param name="produtoModel">Objeto do modelo</param>
        /// <param name="produtoE">Entity mapeada da base de dados</param>
        private void Atribuir(Produto produtoModel, tbl_produto produtoE)
        {            
            produtoE.CodigoProduto = produtoModel.Codigo;
            produtoE.CodigoBarra = produtoModel.CodigoBarra;
            produtoE.NomeItem = produtoModel.Nome;
            produtoE.Quantidade = produtoModel.Quantidade;         
            produtoE.QuantidadeMinima = produtoModel.QuantidadeMinima;
            produtoE.PrecoCusto = produtoModel.PrecoCusto;
            produtoE.PrecoVenda = produtoModel.PrecoVenda;
        }
    }
}
