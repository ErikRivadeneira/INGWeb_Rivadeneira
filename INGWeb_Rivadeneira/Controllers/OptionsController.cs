using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INGWeb_Rivadeneira.Models;

namespace INGWeb_Rivadeneira.Controllers
{
    public class OptionsController : Controller
    {
        private INGDbContext db = new INGDbContext();

        // GET: Options
        public ActionResult Index()
        {
            var options = db.Options.Include(o => o.Questions);
            return View(options.ToList());
        }

        // GET: Options/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Options options = db.Options.Find(id);
            if (options == null)
            {
                return HttpNotFound();
            }
            return View(options);
        }

        // GET: Options/Create
        public ActionResult Create()
        {
            ViewBag.QuestionsID = new SelectList(db.Questions, "QuestionsID", "QuestionText");
            return View();
        }

        // POST: Options/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OptionsID,QuestionsID,optionText,correctOption")] Options options)
        {
            if (ModelState.IsValid)
            {
                db.Options.Add(options);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.QuestionsID = new SelectList(db.Questions, "QuestionsID", "QuestionText", options.QuestionsID);
            return View(options);
        }

        // GET: Options/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Options options = db.Options.Find(id);
            if (options == null)
            {
                return HttpNotFound();
            }
            ViewBag.QuestionsID = new SelectList(db.Questions, "QuestionsID", "QuestionText", options.QuestionsID);
            return View(options);
        }

        // POST: Options/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OptionsID,QuestionsID,optionText,correctOption")] Options options)
        {
            if (ModelState.IsValid)
            {
                db.Entry(options).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.QuestionsID = new SelectList(db.Questions, "QuestionsID", "QuestionText", options.QuestionsID);
            return View(options);
        }

        // GET: Options/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Options options = db.Options.Find(id);
            if (options == null)
            {
                return HttpNotFound();
            }
            return View(options);
        }

        // POST: Options/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Options options = db.Options.Find(id);
            db.Options.Remove(options);
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
