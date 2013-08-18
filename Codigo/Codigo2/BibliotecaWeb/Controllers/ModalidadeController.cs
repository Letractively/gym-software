using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;

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
        public ActionResult Create(Modalidade editoraModel)
        {
            if (ModelState.IsValid)
            {
                gModalidade.Inserir(editoraModel);
                return RedirectToAction("Index");
            }

            return View(editoraModel);
        }
        
        //
        // GET: /Modalidade/Edit/5
 
        public ActionResult Edit(int id)
        {
            Modalidade editoraModel = gModalidade.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Modalidade/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Modalidade editoraModel)
        {
            if (ModelState.IsValid)
            {
                gModalidade.Editar(editoraModel);
                return RedirectToAction("Index");
            }
            return View(editoraModel);
        }

        //
        // GET: /Modalidade/Delete/5
 
        public ActionResult Delete(int id)
        {
            Modalidade editoraModel = gModalidade.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Modalidade/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Modalidade editoraModel)
        {
            gModalidade.Remover(id);
            return RedirectToAction("Index");
            View();
        }

    }
}
