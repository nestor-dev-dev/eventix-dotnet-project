using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppEventix.Models;

namespace WebAppEventix.Controllers
{
    [Authorize]
    public class VisitaTuristicaGuiadasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: VisitaTuristicaGuiadas
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userVisitasTuristicas = db.VisitaTuristicaGuiadas.Where(p=> p.UserId == currentUserId).ToList();
            return View(userVisitasTuristicas);
        }

        // GET: VisitaTuristicaGuiadas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitaTuristicaGuiada visitaTuristicaGuiada = db.VisitaTuristicaGuiadas.Find(id);
            string currentUserId = User.Identity?.GetUserId();
            if (visitaTuristicaGuiada == null || visitaTuristicaGuiada.UserId != currentUserId)
            {
                return HttpNotFound();
            }
            return View(visitaTuristicaGuiada);
        }

        // GET: VisitaTuristicaGuiadas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VisitaTuristicaGuiadas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ciudad,TituloRecorrido,Pago,AgenciaTourOperadora,Tipo,FechaHora,DuracionEstimada,Precio,LugarInicio,LugarFin")] VisitaTuristicaGuiada visitaTuristicaGuiada)
        {
            string currentUserId = User.Identity.GetUserId();
            visitaTuristicaGuiada.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.VisitaTuristicaGuiadas.Add(visitaTuristicaGuiada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(visitaTuristicaGuiada);
        }

        // GET: VisitaTuristicaGuiadas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitaTuristicaGuiada visitaTuristicaGuiada = db.VisitaTuristicaGuiadas.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if (visitaTuristicaGuiada == null || visitaTuristicaGuiada.UserId != currentUserId)
            {
                return HttpNotFound();
            }
            return View(visitaTuristicaGuiada);
        }

        // POST: VisitaTuristicaGuiadas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ciudad,TituloRecorrido,Pago,AgenciaTourOperadora,Tipo,FechaHora,DuracionEstimada,Precio,LugarInicio,LugarFin")] VisitaTuristicaGuiada visitaTuristicaGuiada)
        {
            string currentUserId = User.Identity.GetUserId();
            visitaTuristicaGuiada.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(visitaTuristicaGuiada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visitaTuristicaGuiada);
        }

        // GET: VisitaTuristicaGuiadas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VisitaTuristicaGuiada visitaTuristicaGuiada = db.VisitaTuristicaGuiadas.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if (visitaTuristicaGuiada == null || visitaTuristicaGuiada.UserId != currentUserId)
            {
                return HttpNotFound();
            }
            return View(visitaTuristicaGuiada);
        }

        // POST: VisitaTuristicaGuiadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VisitaTuristicaGuiada visitaTuristicaGuiada = db.VisitaTuristicaGuiadas.Find(id);
            db.VisitaTuristicaGuiadas.Remove(visitaTuristicaGuiada);
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
