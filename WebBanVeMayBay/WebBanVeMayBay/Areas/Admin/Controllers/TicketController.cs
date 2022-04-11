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
    public class TicketController : Controller
    {
        private WebBanVeMayBayDBContext db = new WebBanVeMayBayDBContext();
        // GET: Admin/Ticket
        public ActionResult Index(Ticket ticket)
        {
            var list = db.Ticket
               .OrderByDescending(c => c.CreateDate)
               .ToList();
            return View("Index", list);
        }
        public ActionResult Status(int id)
        {
            Ticket ticket = db.Ticket.Find(id);
            int status = (ticket.Status == 0) ? 1 : 0;
            ticket.Status = status;

            if (ticket.Status == 1)
            {
                Product product = db.Products.Find(ticket.PlanId);
                product.Seat1++;
                product.Seat2--;
            }
            db.Entry(ticket).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Ticket");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Ticket.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Ticket ticket = db.Ticket.Find(id);
            db.Ticket.Remove(ticket);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Filter(string Filter)
        {
            if (Filter == "Đã Thanh Toán")
            {
                var list = db.Ticket
               .Where(c => c.Status == 1)
               .OrderByDescending(c => c.CreateDate)
               .ToList();
                return View("Index", list);
            }
            else
            {
                var list = db.Ticket
               .Where(c => c.Status == 0)
               .OrderByDescending(c => c.CreateDate)
               .ToList();
                return View("Index", list);
            }

        }

        public ActionResult BillExport(int id)
        {
            Ticket ticket = db.Ticket.Find(id);
            Bill bill = new Bill();
            bill.TicketId = ticket.Id;
            bill.PlanId = ticket.PlanId;
            bill.PlanName = ticket.PlanName;
            bill.Time = ticket.Time;
            bill.Date = ticket.Date;
            bill.Price = ticket.Price;
            bill.PhoneNumber = ticket.PhoneNumber;
            bill.ClientId = ticket.ClientId;
            bill.ClientName = ticket.ClientName;
            return View(bill);
        }







    }
}