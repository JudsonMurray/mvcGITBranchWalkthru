using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvcGITBranchWalkthru.Models;

namespace mvcGITBranchWalkthru.Controllers
{
    public class GitAccountsController : Controller
    {
        private GitContext db = new GitContext();

        // GET: GitAccounts
        public ActionResult Index()
        {
            return View(db.GitAccounts.ToList());
        }

        // GET: GitAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GitAccount gitAccount = db.GitAccounts.Find(id);
            if (gitAccount == null)
            {
                return HttpNotFound();
            }
            return View(gitAccount);
        }

        // GET: GitAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GitAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,EmailAddress")] GitAccount gitAccount)
        {
            if (ModelState.IsValid)
            {
                db.GitAccounts.Add(gitAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gitAccount);
        }

        // GET: GitAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GitAccount gitAccount = db.GitAccounts.Find(id);
            if (gitAccount == null)
            {
                return HttpNotFound();
            }
            return View(gitAccount);
        }

        // POST: GitAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,EmailAddress")] GitAccount gitAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gitAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gitAccount);
        }

        // GET: GitAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GitAccount gitAccount = db.GitAccounts.Find(id);
            if (gitAccount == null)
            {
                return HttpNotFound();
            }
            return View(gitAccount);
        }

        // POST: GitAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GitAccount gitAccount = db.GitAccounts.Find(id);
            db.GitAccounts.Remove(gitAccount);
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
