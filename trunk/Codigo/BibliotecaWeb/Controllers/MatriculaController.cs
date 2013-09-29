using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;

namespace BibliotecaWeb.Controllers
{
    public class MatriculaController : Controller
    {
        
        //
        // GET: /Matricula/

        GerenciadorModalidade gModalidade;
        GerenciadorMatricula gMatricula;
        GerenciadorAluno gAluno;

        public MatriculaController()
        {
            gModalidade = new GerenciadorModalidade();
            gMatricula = new GerenciadorMatricula();
            gAluno = new GerenciadorAluno();
        }

        public ActionResult Index()
        {
            return View(gAluno.ObterTodos());
        }


        //
        // GET: /Matricula/Create

        public ActionResult Create(int id)
        {

            ViewBag.Modalidade = new SelectList(gModalidade.ObterTodos(), "CodigoModalidade", "NomeModalidade");
            ViewBag.Id = id;
            return View();
        }

        //
        // POST: /Matricula/Create

        [HttpPost]
        public ActionResult Create(Matricula matriculaModel)
        {
            if (ModelState.IsValid)
            {
                gMatricula.Inserir(matriculaModel);
                return RedirectToAction("Index");
            }

            return View(matriculaModel);
        }

        //
        // GET: /Aluno/Edit/5

        public ActionResult Edit(int id)
        {

            Aluno aluno = gAluno.Obter(id);
            ViewBag.Id = aluno.Matricula;
            ViewBag.Nome = aluno.NomeRazao;
            return View(gMatricula.ObterTodasModalidadesAluno(id));
        }




        //
        // GET: /Matricula/Delete/5

        public ActionResult Delete(int id)
        {
            Matricula matriculaModel = gMatricula.Obter(id);
            return View(matriculaModel);
        }

        //
        // POST: /Matricula/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Matricula matriculaModel)
        {
            gMatricula.Remover(id);
            return RedirectToAction("Index");            
        }
    }
}
