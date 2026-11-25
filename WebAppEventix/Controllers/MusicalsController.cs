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
    public class MusicalsController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Musicals
        public ActionResult Index()
        {
            string currentUserId = User.Identity.GetUserId();
            var userMusicales = db.Musicals.Where(p=> p.UserId == currentUserId).ToList();
            return View(userMusicales);
        }

        // GET: Musicals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical musical = db.Musicals.Find(id);
            string currentUserId = User.Identity?.GetUserId();
            if ((musical.UserId != currentUserId)||(musical==null))
            {
                return HttpNotFound();
            }
            return View(musical);
        }

        // GET: Musicals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Musicals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,Sinopsis,ActoresPrincipales,Ciudad,Lugar,Productor,DiaDelEspectador,FechaHora,DuracionEstimada,PrecioMinimo,PrecioMedio,PrecioMaximo,DescripcionPrecios")] Musical musical)
        {
            string currentUserId = User.Identity.GetUserId();
            musical.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Musicals.Add(musical);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musical);
        }

        // GET: Musicals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical musical = db.Musicals.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((musical.UserId != currentUserId) || (musical == null))
            {
                return HttpNotFound();
            }
            return View(musical);
        }

        // POST: Musicals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,Sinopsis,ActoresPrincipales,Ciudad,Lugar,Productor,DiaDelEspectador,FechaHora,DuracionEstimada,PrecioMinimo,PrecioMedio,PrecioMaximo,DescripcionPrecios")] Musical musical)
        {
            string currentUserId = User.Identity.GetUserId();
            musical.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(musical).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musical);
        }

        // GET: Musicals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musical musical = db.Musicals.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((musical.UserId != currentUserId) || (musical == null))
            {
                return HttpNotFound();
            }
            return View(musical);
        }

        // POST: Musicals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Musical musical = db.Musicals.Find(id);
            db.Musicals.Remove(musical);
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
