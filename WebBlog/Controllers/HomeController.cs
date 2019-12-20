using BlogDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ArticleService myCl = new ArticleService();
            //string getStr = myCl.ConnectionStr;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}