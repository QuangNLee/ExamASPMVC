using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exam.Context;
using Exam.Models;

namespace Exam.Controllers
{
    public class ExamInfoController : Controller
    {
        private DataContext db = new DataContext();

        // GET: ExamInfo
        public ActionResult Index()
        {
            return View(db.ExamInfos.ToList());
        }

        // GET: ExamInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamInfo examInfo = db.ExamInfos.Find(id);
            if (examInfo == null)
            {
                return HttpNotFound();
            }
            return View(examInfo);
        }

        // GET: ExamInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Subject,StartTime,ExamDate,Duration,Classroom,Faculty,Status")] ExamInfo examInfo)
        {
            if (ModelState.IsValid)
            {
                db.ExamInfos.Add(examInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(examInfo);
        }

        // GET: ExamInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamInfo examInfo = db.ExamInfos.Find(id);
            if (examInfo == null)
            {
                return HttpNotFound();
            }
            return View(examInfo);
        }

        // POST: ExamInfo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Subject,StartTime,ExamDate,Duration,Classroom,Faculty,Status")] ExamInfo examInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(examInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(examInfo);
        }

        // GET: ExamInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamInfo examInfo = db.ExamInfos.Find(id);
            if (examInfo == null)
            {
                return HttpNotFound();
            }
            return View(examInfo);
        }

        // POST: ExamInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExamInfo examInfo = db.ExamInfos.Find(id);
            db.ExamInfos.Remove(examInfo);
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
