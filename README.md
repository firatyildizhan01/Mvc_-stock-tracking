
# MvCStok

MvcStok is stock tracking program . You can reach your categories,products,prices and stocks anywhere.

## Using Technologies

 Asp.net Mvc, .net, html , boostrap , mssql


![image](https://user-images.githubusercontent.com/32723458/119501915-0273d880-bd72-11eb-93c7-2c9f36e03c8d.png)

  


[![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg?)](https://github.com/tterb/atomic-design-ui/blob/master/LICENSEs)
[![GPLv3 License](https://img.shields.io/badge/License-GPL%20v3-yellow.svg)](https://opensource.org/licenses/)
[![AGPL License](https://img.shields.io/badge/license-AGPL-blue.svg)](http://www.gnu.org/licenses/agpl-3.0)

  

  
## Features

- Can you reach anywhere
- Basic interface
- Add-remove or update
- change values

  ![image](https://user-images.githubusercontent.com/32723458/119501938-0acc1380-bd72-11eb-93ac-32997e584751.png)



```bash 
  npm install my-project
  cd my-project
```
    
  ![image](https://user-images.githubusercontent.com/32723458/119501993-1a4b5c80-bd72-11eb-81c5-d913b997426a.png)

## Tests


```bash
  npm run test
```

  
## Using Examples

```



    public class UrunController : Controller
    {
        MVCdbStokEntities db = new MVCdbStokEntities();
        // GET: Urun
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> degerler = (from i in db.TBLKATEGORILER.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();  
        }
        [HttpPost]
        public ActionResult UrunEkle(TBLURUNLER p1)
        {
            var ktg = db.TBLKATEGORILER.Where(m => m.KATEGORIID == p1.TBLKATEGORILER.KATEGORIID).FirstOrDefault();
            p1.TBLKATEGORILER = ktg;
            db.TBLURUNLER.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var urun = db.TBLURUNLER.Find(id);
            db.TBLURUNLER.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
}
```

  
