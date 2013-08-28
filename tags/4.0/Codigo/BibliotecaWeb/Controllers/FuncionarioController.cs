using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;

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
    }
}
