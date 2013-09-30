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
    public class AtividadeController : Controller
    {
        
        //
        // GET: /Atividade/

        GerenciadorModalidade gModalidade;
        GerenciadorAtividade gAtividade;

        public AtividadeController()
        {
            gModalidade = new GerenciadorModalidade();
            gAtividade = new GerenciadorAtividade();
        }

        public ActionResult Index()
        {
            return View(gAtividade.ObterTodos());
        }


        //
        // GET: /Atividade/Create

        public ActionResult Create()
        {
            ViewBag.Modalidade = new SelectList(gModalidade.ObterTodos(), "Codigo", "Nome");
            return View();
        }

        //
        // POST: /Atividade/Create

        [HttpPost]
        public ActionResult Create(Atividade atividadeModel)
        {
            if (ModelState.IsValid)
            {
                gAtividade.Inserir(atividadeModel);
                return RedirectToAction("Index");
            }

            return View(atividadeModel);
        }

     

        //
        // GET: /Atividade/Delete/5

        public ActionResult Delete(int id)
        {
            Atividade atividadeModel = gAtividade.Obter(id);
            return View(atividadeModel);
        }

        //
        // POST: /Atividade/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Atividade atividadeModel)
        {
            gAtividade.Remover(id);
            return RedirectToAction("Index");            
        }

        public ActionResult RelatorioAtividadePorModalidade()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Reports/ReportListaAtividadePorModalidade.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetAtividadePorModalidade", gAtividade.ObterTodos()));

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
