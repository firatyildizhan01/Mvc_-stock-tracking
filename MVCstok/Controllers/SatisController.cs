using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCstok.Models.Entity;

namespace MVCstok.Controllers
{
    public class SatisController : Controller
    {
        MVCdbStokEntities db = new MVCdbStokEntities();
        // GET: Satis
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }
    }
}