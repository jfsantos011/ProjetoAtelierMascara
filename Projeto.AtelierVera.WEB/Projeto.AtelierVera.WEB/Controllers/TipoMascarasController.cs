using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Atelier.Mascara.Dados.Entity.Context;
using Atelier.Mascara.Dominio;

namespace Projeto.AtelierVera.WEB.Controllers
{
    public class TipoMascarasController : Controller
    {
        private MascaraDBContext db = new MascaraDBContext();

        // GET: TipoMascaras
        public ActionResult Index()
        {
            return View(db.TiposDeMascaras.ToList());
        }

        // GET: TipoMascaras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoMascara tipoMascara = db.TiposDeMascaras.Find(id);
            if (tipoMascara == null)
            {
                return HttpNotFound();
            }
            return View(tipoMascara);
        }

        // GET: TipoMascaras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoMascaras/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Tecido,Cor,Descricao")] TipoMascara tipoMascara)
        {
            if (ModelState.IsValid)
            {
                db.TiposDeMascaras.Add(tipoMascara);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoMascara);
        }

        // GET: TipoMascaras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoMascara tipoMascara = db.TiposDeMascaras.Find(id);
            if (tipoMascara == null)
            {
                return HttpNotFound();
            }
            return View(tipoMascara);
        }

        // POST: TipoMascaras/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Tecido,Cor,Descricao")] TipoMascara tipoMascara)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoMascara).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoMascara);
        }

        // GET: TipoMascaras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoMascara tipoMascara = db.TiposDeMascaras.Find(id);
            if (tipoMascara == null)
            {
                return HttpNotFound();
            }
            return View(tipoMascara);
        }

        // POST: TipoMascaras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoMascara tipoMascara = db.TiposDeMascaras.Find(id);
            db.TiposDeMascaras.Remove(tipoMascara);
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
