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
    public class AlunoController : Controller
    {
        //
        // GET: /Aluno/

        GerenciadorAluno gAluno;

        public AlunoController()
        {
            gAluno = new GerenciadorAluno();
        }

        public ActionResult Index()
        {
            return View(gAluno.ObterTodos());
        }

        //
        // GET: /Aluno/Details/5

        public ActionResult Details(int id)
        {
            return View(gAluno.Obter(id));
        }

        //
        // GET: /Aluno/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Aluno/Create

        [HttpPost]
        public ActionResult Create(Aluno alunoModel)
        {
            if (ModelState.IsValid)
            {
                
                gAluno.Inserir(alunoModel);
                return RedirectToAction("Index");
            }

            return View(alunoModel);
        }

        //
        // GET: /Aluno/Edit/5

        public ActionResult Edit(int id)
        {

            Aluno alunoModel = gAluno.Obter(id);
            return View(alunoModel);
        }

        //
        // POST: /Aluno/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Aluno alunoModel)
        {
            if (ModelState.IsValid)
            {
                gAluno.Editar(alunoModel);
                return RedirectToAction("Index");
            }
            return View(alunoModel);
        }

        //
        // GET: /Aluno/Delete/5

        public ActionResult Delete(int id)
        {
            Aluno alunoModel = gAluno.Obter(id);
            return View(alunoModel);
        }

        //
        // POST: /Aluno/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Aluno alunoModel)
        {
            gAluno.Remover(id);
            return RedirectToAction("Index");
            
        }

        public ActionResult RelatorioAluno()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Reports/ReportListaAlunos.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSet1", gAluno.ObterTodos()));

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
