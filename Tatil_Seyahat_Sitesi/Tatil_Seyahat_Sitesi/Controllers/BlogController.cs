using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Class;
namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        Blogyorum By = new Blogyorum();
        public ActionResult Index()
        {
            //  var degerler = c.Blogs.ToList();
            By.Deger1 = c.Blogs.ToList();
            By.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(By);
        }
        public ActionResult BlogDetay(int id)
        {

            //  var blogbul = c.Blogs.Where(x=> x.ID == id).ToList();
            By.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            By.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(By);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}