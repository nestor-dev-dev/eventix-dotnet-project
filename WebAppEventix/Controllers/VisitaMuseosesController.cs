using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppEventix.Models;
using Microsoft.AspNet.Identity;

namespace WebAppEventix.Controllers
{
    [Authorize]
    public class VisitaMuseosesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: VisitaMuseoses
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userMuseos = db.VisitaMuseos.Where(p=> p.UserId == currentUserId).ToList();
            return View(userMuseos);
        }

        // GET: VisitaMuseoses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitaMuseos visitaMuseos = db.VisitaMuseos.Find(id);
            string currentUserId = User.Identity?.GetUserId();
            if ((visitaMuseos.UserId != currentUserId) || (visitaMuseos == null))
            {
                return HttpNotFound();
            }
            return View(visitaMuseos);
        }

        // GET: VisitaMuseoses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VisitaMuseoses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VisitaMuseosId,TituloVisita,NombreMuseo,DiasCerrado,ObrasDestacadas,PrecioEntrada")] VisitaMuseos visitaMuseos)
        {
            string currentUserId = User.Identity.GetUserId();
            visitaMuseos.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.VisitaMuseos.Add(visitaMuseos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(visitaMuseos);
        }

        // GET: VisitaMuseoses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitaMuseos visitaMuseos = db.VisitaMuseos.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((visitaMuseos.UserId != currentUserId) || (visitaMuseos == null))
            {
                return HttpNotFound();
            }
            return View(visitaMuseos);
        }

        // POST: VisitaMuseoses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VisitaMuseosId,TituloVisita,NombreMuseo,DiasCerrado,ObrasDestacadas,PrecioEntrada")] VisitaMuseos visitaMuseos)
        {
            string currentUserId = User.Identity.GetUserId();
            visitaMuseos.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(visitaMuseos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visitaMuseos);
        }

        // GET: VisitaMuseoses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitaMuseos visitaMuseos = db.VisitaMuseos.Find(id);
            string currentUserId = User.Identity.GetUserId();
                if ((visitaMuseos.UserId != currentUserId) || (visitaMuseos == null))
            {
                return HttpNotFound();
            }
            return View(visitaMuseos);
        }

        // POST: VisitaMuseoses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VisitaMuseos visitaMuseos = db.VisitaMuseos.Find(id);
            db.VisitaMuseos.Remove(visitaMuseos);
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
