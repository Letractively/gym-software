using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;

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
    }
}
