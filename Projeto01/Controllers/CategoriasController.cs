using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto01.Models;

namespace Projeto01.Controllers
{
    public class CategoriasController : Controller
    {

        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria() { CategoriaID = 1, Nome = "Notebooks"},
            new Categoria() { CategoriaID = 2, Nome = "Monitores"},
            new Categoria() { CategoriaID = 3, Nome = "Impressoras"},
            new Categoria() { CategoriaID = 4, Nome = "Mouses"},
            new Categoria() { CategoriaID = 5, Nome = "Desktops"}
        };

        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }

        // GET: Categorias
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: Categorias Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            categorias.Add(categoria);
            categoria.CategoriaID = categorias.Select(m => m.CategoriaID).Max() + 1;
            return RedirectToAction("Index");
        }

        // GET: Categorias
        public ActionResult Edit(long id)
        {
            return View(categorias.Where(m => m.CategoriaID == id).First());
        }

        // POST: Categorias Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            categorias.Remove(
            categorias.Where(c => c.CategoriaID == categoria.CategoriaID).First());
            categorias.Add(categoria);
            return RedirectToAction("Index");
        }

        // GET: Categorias Details
        public ActionResult Details(long id)
        {
            return View(categorias.Where(m => m.CategoriaID == id).First());
        }

        // GET: Categorias Delete
        public ActionResult Delete(long id)
        {
            return View(categorias.Where(m => m.CategoriaID == id).First());
        }

        // POST: Categorias Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categoria categoria)
        {
            categorias.Remove(
            categorias.Where(c => c.CategoriaID == categoria.CategoriaID).First());
            return RedirectToAction("Index");
        }
    }
}