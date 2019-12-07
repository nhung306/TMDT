using _1611061638_Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1611061638_Lab2.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Danhsachdanhmuc()
        {
            NhadatEntities db = new NhadatEntities();
            var danhsachdanhmuc = from s in db.Categories select s;
            return View(danhsachdanhmuc);
        }
    }
}