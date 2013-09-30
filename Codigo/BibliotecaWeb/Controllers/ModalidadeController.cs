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
    public class ModalidadeController : Controller
    {

        //
        // GET: /Modalidade/

        GerenciadorModalidade gModalidade;

        public ModalidadeController()
        {
            gModalidade = new GerenciadorModalidade();
        }

        public ActionResult Index()
        {
            return View(gModalidade.ObterTodos());
        }

        //
        // GET: /Modalidade/Details/5

        public ActionResult Details(int id)
        {
            return View(gModalidade.Obter(id));
        }

        //
        // GET: /Modalidade/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Modalidade/Create

        [HttpPost]
        public ActionResult Create(Modalidade modalidadeModel)
        {
            if (ModelState.IsValid)
            {
                gModalidade.Inserir(modalidadeModel);
                return RedirectToAction("Index");
            }

            return View(modalidadeModel);
        }
        
        //
        // GET: /Modalidade/Edit/5
 
        public ActionResult Edit(int id)
        {
            Modalidade modalidadeModel = gModalidade.Obter(id);
            return View(modalidadeModel);
        }

        //
        // POST: /Modalidade/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Modalidade modalidadeModel)
        {
            if (ModelState.IsValid)
            {
                gModalidade.Editar(modalidadeModel);
                return RedirectToAction("Index");
            }
            return View(modalidadeModel);
        }

        //
        // GET: /Modalidade/Delete/5
 
        public ActionResult Delete(int id)
        {
            Modalidade modalidadeModel = gModalidade.Obter(id);
            return View(modalidadeModel);
        }

        //
        // POST: /Modalidade/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Modalidade modalidadeModel)
        {
            gModalidade.Remover(id);
            return RedirectToAction("Index");
            
        }

        public ActionResult RelatorioModalidadePorPreco()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Reports/ReportListaModalidadePorPreco.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetModalidadePorPreco", gModalidade.ObterTodos()));

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
