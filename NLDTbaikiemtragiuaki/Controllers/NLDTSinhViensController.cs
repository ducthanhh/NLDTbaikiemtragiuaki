using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLDTbaikiemtragiuaki.Models;

namespace NLDTbaikiemtragiuaki.Controllers
{
    public class NLDTSinhViensController : Controller
    {
        private NLDTK22CNT3lession07Entities db = new NLDTK22CNT3lession07Entities();

        // GET: NLDTSinhViens
        public ActionResult NLDTIndex()
        {
            var nLDTSinhVien = db.NLDTSinhVien.Include(n => n.NLDTKhoa);
            return View(nLDTSinhVien.ToList());
        }

        // GET: NLDTSinhViens/Details/5
        public ActionResult NLDTDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTSinhVien nLDTSinhVien = db.NLDTSinhVien.Find(id);
            if (nLDTSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nLDTSinhVien);
        }

        // GET: NLDTSinhViens/Create
        public ActionResult NLDTCreate()
        {
            ViewBag.NLDTMaKH = new SelectList(db.NLDTKhoa, "NLDTMaKH", "NLDTTenKH");
            return View();
        }

        // POST: NLDTSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTCreate([Bind(Include = "NLDTMaSV,NLDTHoSV,NLDTTenSV,NLDTNgaySInh,NLDTPhai,NLDTPhone,NLDTEmail,NLDTMaKH")] NLDTSinhVien nLDTSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.NLDTSinhVien.Add(nLDTSinhVien);
                db.SaveChanges();
                return RedirectToAction("NLDTIndex");
            }

            ViewBag.NLDTMaKH = new SelectList(db.NLDTKhoa, "NLDTMaKH", "NLDTTenKH", nLDTSinhVien.NLDTMaKH);
            return View(nLDTSinhVien);
        }

        // GET: NLDTSinhViens/Edit/5
        public ActionResult NLDTEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTSinhVien nLDTSinhVien = db.NLDTSinhVien.Find(id);
            if (nLDTSinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.NLDTMaKH = new SelectList(db.NLDTKhoa, "NLDTMaKH", "NLDTTenKH", nLDTSinhVien.NLDTMaKH);
            return View(nLDTSinhVien);
        }

        // POST: NLDTSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTEdit([Bind(Include = "NLDTMaSV,NLDTHoSV,NLDTTenSV,NLDTNgaySInh,NLDTPhai,NLDTPhone,NLDTEmail,NLDTMaKH")] NLDTSinhVien nLDTSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nLDTSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NLDTMaKH = new SelectList(db.NLDTKhoa, "NLDTMaKH", "NLDTTenKH", nLDTSinhVien.NLDTMaKH);
            return View(nLDTSinhVien);
        }

        // GET: NLDTSinhViens/Delete/5
        public ActionResult NLDTDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NLDTSinhVien nLDTSinhVien = db.NLDTSinhVien.Find(id);
            if (nLDTSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(nLDTSinhVien);
        }

        // POST: NLDTSinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult NLDTDeleteConfirmed(string id)
        {
            NLDTSinhVien nLDTSinhVien = db.NLDTSinhVien.Find(id);
            db.NLDTSinhVien.Remove(nLDTSinhVien);
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
