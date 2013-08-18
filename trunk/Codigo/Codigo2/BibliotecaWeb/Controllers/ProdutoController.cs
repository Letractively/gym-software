using System.Web.Mvc;
using Models.Models;
using Services;


namespace BibliotecaWeb.Controllers
{
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/

        GerenciadorProduto gProduto;

        public ProdutoController()
        {
            gProduto = new GerenciadorProduto();
        }

        public ActionResult Index()
        {
            return View(gProduto.ObterTodos());
        }

        //
        // GET: /Produto/Details/5

        public ActionResult Details(int id)
        {
            return View(gProduto.Obter(id));
        }

        //
        // GET: /Produto/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Produto/Create

        [HttpPost]
        public ActionResult Create(Produto editoraModel)
        {
            if (ModelState.IsValid)
            {
                gProduto.Inserir(editoraModel);
                return RedirectToAction("Index");
            }

            return View(editoraModel);
        }
        
        //
        // GET: /Produto/Edit/5
 
        public ActionResult Edit(int id)
        {
            Produto editoraModel = gProduto.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Produto/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Produto editoraModel)
        {
            if (ModelState.IsValid)
            {
                gProduto.Editar(editoraModel);
                return RedirectToAction("Index");
            }
            return View(editoraModel);
        }

        //
        // GET: /Produto/Delete/5
 
        public ActionResult Delete(int id)
        {
            Produto editoraModel = gProduto.Obter(id);
            return View(editoraModel);
        }

        //
        // POST: /Produto/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Produto editoraModel)
        {
            gProduto.Remover(id);
            return RedirectToAction("Index");
            View();
        }
    }
}
