using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;

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
    }
}
