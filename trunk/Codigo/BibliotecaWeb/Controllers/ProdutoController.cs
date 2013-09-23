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
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/

        GerenciadorProduto gProduto;

        public ProdutoController()
        {
            gProduto = new GerenciadorProduto();
        }

        public ActionResult Index()
        {
            return View(gProduto.ObterTodos());
        }

        //
        // GET: /Produto/Details/5

        public ActionResult Details(int id)
        {
            return View(gProduto.Obter(id));
        }

        //
        // GET: /Produto/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Produto/Create

        [HttpPost]
        public ActionResult Create(Produto editoraModel)
        {
            if (ModelState.IsValid)
            {
                gProduto.Inserir(editoraModel);
                return RedirectToAction("Index");
            }

            return View(editoraModel);
        }

        //
        // GET: /Produto/Edit/5

        public ActionResult Edit(int id)
        {
            Produto editoraModel = gProduto.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Produto/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Produto editoraModel)
        {
            if (ModelState.IsValid)
            {
                gProduto.Editar(editoraModel);
                return RedirectToAction("Index");
            }
            return View(editoraModel);
        }

        //
        // GET: /Produto/Delete/5

        public ActionResult Delete(int id)
        {
            Produto editoraModel = gProduto.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Produto/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Produto editoraModel)
        {
            gProduto.Remover(id);
            return RedirectToAction("Index");
            
        }

        public ActionResult RelatorioProduto()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Reports/ReportListaProduto.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetProduto", gProduto.ObterTodos()));

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
