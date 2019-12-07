using _1611061638_Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1611061638_Lab2.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Danhsachbaiviet()
        {
            NhadatEntities db = new NhadatEntities();
            var danhsachbaiviet = from s in db.News select s;

            return View(danhsachbaiviet);
        }


        public ActionResult ChiTiet(int id)
        {
            NhadatEntities db = new NhadatEntities();

            var baiviet = db.News.SingleOrDefault(s => s.ID == id);

            return View(baiviet);

            
        }
    }
}