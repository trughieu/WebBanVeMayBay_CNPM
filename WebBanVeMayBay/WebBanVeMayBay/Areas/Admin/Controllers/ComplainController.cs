using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBanVeMayBay.Models;

namespace WebBanVeMayBay.Areas.Admin.Controllers
{

    public class ComplainController : Controller
    {
        private WebBanVeMayBayDBContext db = new WebBanVeMayBayDBContext();
        // GET: Admin/Complain
        public ActionResult Index(Complain complain)
        {
            var list = db.Complain
              .OrderByDescending(c => c.CreateSend)
              .ToList();
            return View("Index", list);
        }


        public ActionResult Status(int id)
        {
            Complain complain = db.Complain.Find(id);
            int status = (complain.status == 0) ? 1 : 0;
            complain.status = status;
            //product.Update_By = int.Parse(Session["UserId"].ToString());
            db.Entry(complain).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Complain");
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Complain complain = db.Complain.Find(id);
            if (complain == null)
            {
                return HttpNotFound();
            }
            return View(complain);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Complain complain = db.Complain.Find(id);
            db.Complain.Remove(complain);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Filter(string Filter)
        {
            if (Filter == "Đã giải quyết")
            {
                var list = db.Complain
               .Where(c => c.status == 1)
               .OrderByDescending(c => c.CreateSend)
               .ToList();
                return View("Index", list);
            }
            else
            {
                var list = db.Complain
               .Where(c => c.status == 0)
               .OrderByDescending(c => c.CreateSend)
               .ToList();
                return View("Index", list);
            }
            
        }

    }
}