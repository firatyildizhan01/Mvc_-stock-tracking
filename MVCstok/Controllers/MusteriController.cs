using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCstok.Models.Entity;

namespace MVCstok.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MVCdbStokEntities db = new MVCdbStokEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERILER.ToList();
            return View(degerler);
        }
    }
}