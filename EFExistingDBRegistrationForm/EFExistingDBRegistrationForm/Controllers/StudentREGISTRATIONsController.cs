using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EFExistingDBRegistrationForm;

namespace EFExistingDBRegistrationForm.Controllers
{
    public class StudentREGISTRATIONsController : Controller
    {
        private Register db = new Register();

        // GET: StudentREGISTRATIONs
        public ActionResult Index()
        {
            return View(db.StudentREGISTRATIONs.ToList());
        }

        // GET: StudentREGISTRATIONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentREGISTRATION studentREGISTRATION = db.StudentREGISTRATIONs.Find(id);
            if (studentREGISTRATION == null)
            {
                return HttpNotFound();
            }
            return View(studentREGISTRATION);
        }

        // GET: StudentREGISTRATIONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentREGISTRATIONs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Registration_Id,Name,Address,Mobile_Number,Email_id,Password,Conform_Password,Age,Gender,Date_of_Birth,Courses,Registration_Date,Photo")] StudentREGISTRATION studentREGISTRATION)
        {
            if (ModelState.IsValid)
            {
                db.StudentREGISTRATIONs.Add(studentREGISTRATION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentREGISTRATION);
        }

        // GET: StudentREGISTRATIONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentREGISTRATION studentREGISTRATION = db.StudentREGISTRATIONs.Find(id);
            if (studentREGISTRATION == null)
            {
                return HttpNotFound();
            }
            return View(studentREGISTRATION);
        }

        // POST: StudentREGISTRATIONs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Registration_Id,Name,Address,Mobile_Number,Email_id,Password,Conform_Password,Age,Gender,Date_of_Birth,Courses,Registration_Date,Photo")] StudentREGISTRATION studentREGISTRATION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentREGISTRATION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentREGISTRATION);
        }

        // GET: StudentREGISTRATIONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentREGISTRATION studentREGISTRATION = db.StudentREGISTRATIONs.Find(id);
            if (studentREGISTRATION == null)
            {
                return HttpNotFound();
            }
            return View(studentREGISTRATION);
        }

        // POST: StudentREGISTRATIONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentREGISTRATION studentREGISTRATION = db.StudentREGISTRATIONs.Find(id);
            db.StudentREGISTRATIONs.Remove(studentREGISTRATION);
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
