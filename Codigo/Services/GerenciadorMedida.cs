using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorMedida
    {
        private GerenciadorAluno gAluno;
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorMedida()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
            gAluno = new GerenciadorAluno(unitOfWork);
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorMedida(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="medidaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(Medida medidaModel)
        {
           /* tbl_medida medidaE = new tbl_medida();
            Atribuir(medidaModel, medidaE);
            unitOfWork.RepositorioMedida.Inserir(medidaE);
            unitOfWork.Commit(shared);
            return medidaE.CodigoMedida;*/

            
            int codigoAluno = gAluno.Inserir(medidaModel);
            tbl_medida medidaE = new tbl_medida();

            Atribuir(medidaModel, medidaE);
            unitOfWork.RepositorioMedida.Inserir(medidaE);
            unitOfWork.Commit(shared);

            return medidaE.CodigoMedida;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="medidaModel"></param>
        public void Editar(Medida medidaModel)
        {
            gAluno.Editar(medidaModel);
            tbl_medida medidaE = new tbl_medida();
            Atribuir(medidaModel, medidaE);
            unitOfWork.RepositorioMedida.Editar(medidaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="medidaModel"></param>
        public void Remover(int CodigoMedida)
        {
            unitOfWork.RepositorioMedida.Remover(medida => medida.CodigoMedida.Equals(CodigoMedida));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do medida como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Medida> GetQuery()
        {
            IQueryable<tbl_medida> tbl_medida = unitOfWork.RepositorioMedida.GetQueryable();
            IQueryable<tbl_aluno> tbl_aluno = unitOfWork.RepositorioAluno.GetQueryable();

            var query = from medida in tbl_medida
                        join aluno in tbl_aluno
                        on medida.Matricula equals aluno.Matricula

                        select new Medida
                        {
                            CodigoMedida = medida.CodigoMedida,
                            Matricula = medida.Matricula,
                            Data = medida.Data,
                            Altura = medida.Altura,
                            Peso = medida.Peso,
                            IMC = medida.IMC,
                            Gordura = medida.Gordura,
                            Abdomen = medida.Abdomen,
                            Cintura = medida.Cintura,
                            Costa = medida.Costa,
                            Peitoral = medida.Peitoral,
                            Quadril = medida.Quadril,
                            Ombro = medida.Ombro,
                            BicepsEsq = medida.BicepsEsq,
                            BicepsDir = medida.BicepsDir,
                            AnteBracoEsq = medida.AnteBracoEsq,
                            AnteBracoDir = medida.AnteBracoDir,
                            CoxaEsq = medida.CoxaEsq,
                            CoxaDir = medida.CoxaDir,
                            PanturrilhaEsq = medida.PanturrilhaEsq,
                            PanturrilhaDir = medida.PanturrilhaDir
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Medida> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um medida
        /// </summary>
        /// <param name="idMedida">Identificador do medida na base de dados</param>
        /// <returns>Medida model</returns>
        public Medida Obter(int idMedida)
        {
            IEnumerable<Medida> medidaes = GetQuery().Where(medidaModel => medidaModel.CodigoMedida.Equals(idMedida));
            return medidaes.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Medida Model para o Medida Entity
        /// </summary>
        /// <param name="medidaModel">Objeto do modelo</param>
        /// <param name="medidaE">Entity mapeada da base de dados</param>
        private void Atribuir(Medida medidaModel, tbl_medida medidaE)
        {
            medidaE.CodigoMedida = medidaModel.CodigoMedida;
            medidaE.Matricula = medidaModel.Matricula;
            medidaE.Data = medidaModel.Data;
            medidaE.Altura = medidaModel.Altura;
            medidaE.Peso = medidaModel.Peso;
            medidaE.IMC = medidaModel.IMC;
            medidaE.Gordura = medidaModel.Gordura;
            medidaE.Abdomen = medidaModel.Abdomen;
            medidaE.Cintura = medidaModel.Cintura;
            medidaE.Costa = medidaModel.Costa;
            medidaE.Peitoral = medidaModel.Peitoral;
            medidaE.Quadril = medidaModel.Quadril;
            medidaE.Ombro = medidaModel.Ombro;
            medidaE.BicepsEsq = medidaModel.BicepsEsq;
            medidaE.BicepsDir = medidaModel.BicepsDir;
            medidaE.AnteBracoEsq = medidaModel.AnteBracoEsq;
            medidaE.AnteBracoDir = medidaModel.AnteBracoDir;
            medidaE.CoxaEsq = medidaModel.CoxaEsq;
            medidaE.CoxaDir = medidaModel.CoxaDir;
            medidaE.PanturrilhaEsq = medidaModel.PanturrilhaEsq;
            medidaE.PanturrilhaDir = medidaModel.PanturrilhaDir;
        }
    }
}