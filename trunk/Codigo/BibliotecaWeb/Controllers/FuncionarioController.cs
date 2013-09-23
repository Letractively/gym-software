using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{
    public class FuncionarioController : Controller
    {
        //
        // GET: /Funcionario/

        GerenciadorFuncionario gFuncionario;

        public FuncionarioController()
        {
            gFuncionario = new GerenciadorFuncionario();
        }

        public ActionResult Index()
        {
            return View(gFuncionario.ObterTodos());
        }

        //
        // GET: /Funcionario/Details/5

        public ActionResult Details(int id)
        {
            return View(gFuncionario.Obter(id));
        }

        //
        // GET: /Funcionario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Funcionario/Create

        [HttpPost]
        public ActionResult Create(Funcionario editoraModel)
        {
            if (ModelState.IsValid)
            {
                gFuncionario.Inserir(editoraModel);
                return RedirectToAction("Index");
            }

            return View(editoraModel);
        }

        //
        // GET: /Funcionario/Edit/5

        public ActionResult Edit(int id)
        {
            Funcionario editoraModel = gFuncionario.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Funcionario/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Funcionario editoraModel)
        {
            if (ModelState.IsValid)
            {
                gFuncionario.Editar(editoraModel);
                return RedirectToAction("Index");
            }
            return View(editoraModel);
        }

        //
        // GET: /Funcionario/Delete/5

        public ActionResult Delete(int id)
        {
            Funcionario editoraModel = gFuncionario.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Funcionario/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Funcionario editoraModel)
        {
            gFuncionario.Remover(id);
            return RedirectToAction("Index");
            
        }
        public ActionResult RelatorioFuncionario()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Reports/ReportListaFuncionario.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetFuncionario", gFuncionario.ObterTodos()));

            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
             "<DeviceInfo>" +
             " <OutputFormat>PDF</OutputFormat>" +
             " <PageWidth>9in</PageWidth>" +
             " <PageHeight>11in</PageHeight>" +
             " <MarginTop>0.7in</MarginTop>" +
             " <MarginLeft>2in</MarginLeft>" +
             " <MarginRight>2in</MarginRight>" +
             " <MarginBottom>0.7in</MarginBottom>" +
             "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] bytes;

            //Renderiza o relatório em bytes
            bytes = relatorio.Render(
            reportType,
            deviceInfo,
            out mimeType,
            out encoding,
            out fileNameExtension,
            out streams,
            out warnings);

            return File(bytes, mimeType);

        }

        public ActionResult RelatorioFuncionarioPorPermicao()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Reports/ReportListaFuncionarioPorPermicao.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetFuncionarioPorPermicao", gFuncionario.ObterTodos()));

            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
             "<DeviceInfo>" +
             " <OutputFormat>PDF</OutputFormat>" +
             " <PageWidth>9in</PageWidth>" +
             " <PageHeight>11in</PageHeight>" +
             " <MarginTop>0.7in</MarginTop>" +
             " <MarginLeft>2in</MarginLeft>" +
             " <MarginRight>2in</MarginRight>" +
             " <MarginBottom>0.7in</MarginBottom>" +
             "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] bytes;

            //Renderiza o relatório em bytes
            bytes = relatorio.Render(
            reportType,
            deviceInfo,
            out mimeType,
            out encoding,
            out fileNameExtension,
            out streams,
            out warnings);

            return File(bytes, mimeType);

        }
    }
}
