using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Tatil_Seyahat_Sitesi.Models.Class;
namespace Tatil_Seyahat_Sitesi.Controllers
{
    public class GirisyapController : Controller
    {
        // GET: Girisyap
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x=>x.Kullanici_Adi==ad.Kullanici_Adi&&x.Sifre==ad.Sifre);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici_Adi,false);
                Session["Kullanici"] = bilgiler.Kullanici_Adi.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
           
        }
        public ActionResult logOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap","Girisyap");
        }
    }
}