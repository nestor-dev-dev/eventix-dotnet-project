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
    public class ObrasTeatroesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ObrasTeatroes
        public ActionResult Index()
        {
            string currentUserID = User.Identity.GetUserId();
            var userObrasTeatros = db.ObrasTeatroes.Where(p => p.UserId == currentUserID).ToList();
            return View(userObrasTeatros);
        }

        // GET: ObrasTeatroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObrasTeatro obrasTeatro = db.ObrasTeatroes.Find(id);
            string currentUserID = User.Identity?.GetUserId();
            if ((obrasTeatro.UserId != currentUserID) || (obrasTeatro == null))
            {
                return HttpNotFound();
            }
            return View(obrasTeatro);
        }

        // GET: ObrasTeatroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ObrasTeatroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ObrasTeatroId,TituloObra,Sinopsis,ActoresPrincipales,Ciudad,Lugar,Productor,DiaDelEspectador,FechaHora,DuracionEstimada,PrecioMinimo,PrecioMedio,PrecioMaximo,DescripcionPrecios")] ObrasTeatro obrasTeatro)
        {
            string currentUserId = User.Identity.GetUserId();
            obrasTeatro.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.ObrasTeatroes.Add(obrasTeatro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obrasTeatro);
        }

        // GET: ObrasTeatroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObrasTeatro obrasTeatro = db.ObrasTeatroes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((obrasTeatro.UserId != currentUserId) || (obrasTeatro == null))
            {
                return HttpNotFound();
            }
            return View(obrasTeatro);
        }

        // POST: ObrasTeatroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ObrasTeatroId,TituloObra,Sinopsis,ActoresPrincipales,Ciudad,Lugar,Productor,DiaDelEspectador,FechaHora,DuracionEstimada,PrecioMinimo,PrecioMedio,PrecioMaximo,DescripcionPrecios")] ObrasTeatro obrasTeatro)
        {
            string currentUserId = User.Identity.GetUserId();
            obrasTeatro.UserId = currentUserId;
            if (ModelState.IsValid)
            {
                db.Entry(obrasTeatro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obrasTeatro);
        }

        // GET: ObrasTeatroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObrasTeatro obrasTeatro = db.ObrasTeatroes.Find(id);
            string currentUserId = User.Identity.GetUserId();
            if ((obrasTeatro.UserId != currentUserId) || (obrasTeatro == null))
            {
                return HttpNotFound();
            }
            return View(obrasTeatro);
        }

        // POST: ObrasTeatroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ObrasTeatro obrasTeatro = db.ObrasTeatroes.Find(id);
            db.ObrasTeatroes.Remove(obrasTeatro);
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
