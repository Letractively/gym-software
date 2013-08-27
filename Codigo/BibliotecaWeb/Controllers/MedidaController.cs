using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;

namespace BibliotecaWeb.Controllers
{
    public class MedidaController : Controller
    {
        //
        // GET: /Medida/

        GerenciadorMedida gMedida;

        public MedidaController()
        {
            gMedida = new GerenciadorMedida();
        }

        public ActionResult Index()
        {
            return View(gMedida.ObterTodos());
        }

        //
        // GET: /Medida/Details/5

        public ActionResult Details(int id)
        {
            return View(gMedida.Obter(id));
        }

        //
        // GET: /Medida/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Medida/Create

        [HttpPost]
        public ActionResult Create(Medida editoraModel)
        {
            if (ModelState.IsValid)
            {
                gMedida.Inserir(editoraModel);
                return RedirectToAction("Index");
            }

            return View(editoraModel);
        }

        //
        // GET: /Medida/Edit/5

        public ActionResult Edit(int id)
        {
            Medida editoraModel = gMedida.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Medida/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Medida editoraModel)
        {
            if (ModelState.IsValid)
            {
                gMedida.Editar(editoraModel);
                return RedirectToAction("Index");
            }
            return View(editoraModel);
        }

        //
        // GET: /Medida/Delete/5

        public ActionResult Delete(int id)
        {
            Medida editoraModel = gMedida.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Medida/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Medida editoraModel)
        {
            gMedida.Remover(id);
            return RedirectToAction("Index");
            View();
        }
    }
}
