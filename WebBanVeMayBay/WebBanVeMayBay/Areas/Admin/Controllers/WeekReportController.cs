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
    public class WeekReportController : Controller
    {
        private WebBanVeMayBayDBContext db = new WebBanVeMayBayDBContext();

        // GET: Admin/WeekReport
        public ActionResult Index()
        {
            var list = db.WeekReport
               .OrderByDescending(c => c.Created_At)
               .ToList();
            return View("Index",list);
        }

        // GET: Admin/WeekReport/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeekReport weekReport = db.WeekReport.Find(id);
            if (weekReport == null)
            {
                return HttpNotFound();
            }
            return View(weekReport);
        }

        // GET: Admin/WeekReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/WeekReport/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Create( WeekReport weekReport)
        {
            if (ModelState.IsValid)
            {
                weekReport.Created_At = DateTime.Now;
                weekReport.Created_By = int.Parse(Session["UserAdmin"].ToString());
                weekReport.Update_At = DateTime.Now;
                weekReport.Update_By = int.Parse(Session["UserAdmin"].ToString());
                db.WeekReport.Add(weekReport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(weekReport);
        }

        // GET: Admin/WeekReport/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeekReport weekReport = db.WeekReport.Find(id);
            if (weekReport == null)
            {
                return HttpNotFound();
            }
            return View(weekReport);
        }

        // POST: Admin/WeekReport/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Day,Number,Revenue,Rate,Created_By,Created_At,Update_By,Update_At")] WeekReport weekReport)
        {
            if (ModelState.IsValid)
            {
                weekReport.Update_At = DateTime.Now;
                weekReport.Update_By = int.Parse(Session["UserAdmin"].ToString());
                db.Entry(weekReport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weekReport);
        }

        // GET: Admin/WeekReport/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeekReport weekReport = db.WeekReport.Find(id);
            if (weekReport == null)
            {
                return HttpNotFound();
            }
            return View(weekReport);
        }

        // POST: Admin/WeekReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WeekReport weekReport = db.WeekReport.Find(id);
            db.WeekReport.Remove(weekReport);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
