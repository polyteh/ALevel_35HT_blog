using BlogDTO;
using BlogDTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebBlog.Mappers;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleService _articleService;
        public ArticleController()
        {
            _articleService = new ArticleService();
        }
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        // GET: Article/Details/5
        //todo add view this action
        public async Task<ActionResult> Details(int id)
        {
            var Article= await _articleService.GetById(id);
            var mappedArticle = WebMapper< ArticleViewModel, ArticleDTO>.MapDTOtoView(Article);
            return View(mappedArticle);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
