using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil_Seyahat_Sitesi.Models.Class;
namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yeniblog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeniblog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir",bl);
        }
        public ActionResult BlogGüncelle(Blog b)
        {
            var bl = c.Blogs.Find(b.ID);
            bl.Aciklama = b.Aciklama;
            bl.bASLİK = b.bASLİK;
            bl.Blogimage = b.Blogimage;
            bl.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");

        }
        public ActionResult YorumGetir(int id)
        {
            var yrm = c.Yorumlars.Find(id);
            return View("YorumGetir", yrm);
        }
        public ActionResult YorumGüncelle(Yorumlar b)
        {
            var yrm = c.Yorumlars.Find(b.ID);
            yrm.KullaniciAdi = b.KullaniciAdi;
            yrm.Mail = b.Mail;
            yrm.Yorum = b.Yorum;           
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}