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
            View();
        }

    }
}
