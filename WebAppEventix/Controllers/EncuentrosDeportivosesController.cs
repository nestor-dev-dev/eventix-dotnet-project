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
    public class EncuentrosDeportivosesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EncuentrosDeportivoses
        public ActionResult Index()
        {
            string currentUserID = User.Identity.GetUserId();
            var userEncuentrosDeportivos = db.EncuentrosDeportivos.Where(p => p.UserID == currentUserID).ToList();
            return View(userEncuentrosDeportivos);
        }

        // GET: EncuentrosDeportivoses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncuentrosDeportivos encuentrosDeportivos = db.EncuentrosDeportivos.Find(id);
            string currentUserID = User.Identity?.GetUserId();
            if ((encuentrosDeportivos == null) || (encuentrosDeportivos.UserID != currentUserID))
            {
                return HttpNotFound();
            }
            return View(encuentrosDeportivos);
        }

        // GET: EncuentrosDeportivoses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EncuentrosDeportivoses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EncuentrosDeportivosId,Deporte,TituloPartido,EquipoLocal,EquipoVisitante,Ciudad,Lugar,Fecha,PrecioMinimo,PrecioMedio,PrecioMaximo")] EncuentrosDeportivos encuentrosDeportivos)
        {
            string currentUserID = User.Identity.GetUserId();
            encuentrosDeportivos.UserID = currentUserID;
            if (ModelState.IsValid)
            {
                db.EncuentrosDeportivos.Add(encuentrosDeportivos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encuentrosDeportivos);
        }

        // GET: EncuentrosDeportivoses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncuentrosDeportivos encuentrosDeportivos = db.EncuentrosDeportivos.Find(id);
            string currentUserID = User.Identity.GetUserId();
            if ((encuentrosDeportivos.UserID != currentUserID)||(encuentrosDeportivos == null))
            {
                return HttpNotFound();
            }
            return View(encuentrosDeportivos);
        }

        // POST: EncuentrosDeportivoses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EncuentrosDeportivosId,Deporte,TituloPartido,EquipoLocal,EquipoVisitante,Ciudad,Lugar,Fecha,PrecioMinimo,PrecioMedio,PrecioMaximo")] EncuentrosDeportivos encuentrosDeportivos)
        {
            string currentUserID = User.Identity.GetUserId();
            encuentrosDeportivos.UserID = currentUserID;
            if (ModelState.IsValid)
            {
                db.Entry(encuentrosDeportivos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encuentrosDeportivos);
        }

        // GET: EncuentrosDeportivoses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncuentrosDeportivos encuentrosDeportivos = db.EncuentrosDeportivos.Find(id);
            string currentUserID = User.Identity.GetUserId();
            if ((encuentrosDeportivos.UserID != currentUserID) || (encuentrosDeportivos == null))
            {
                return HttpNotFound();
            }
            return View(encuentrosDeportivos);
        }

        // POST: EncuentrosDeportivoses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EncuentrosDeportivos encuentrosDeportivos = db.EncuentrosDeportivos.Find(id);
            db.EncuentrosDeportivos.Remove(encuentrosDeportivos);
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
