using ManajemenBarang.Areas.Admin.Models;
using ManajemenBarang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManajemenBarang.Areas.Admin.Controllers
{
    public class BrgMasukController : Controller
    {
        BarangClass mod = new BarangClass();
        private dbStokEntities db = new dbStokEntities();
        ListOptions list = new ListOptions();
        // GET: Admin/BrgMasuk
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                List<spGetBarangMasukJoin_Result> result = mod.getBarangMasuk();
                return View(result);
            }
            return View("ErrorSession");

        }

        public ActionResult InsertExist()
        {
            list.getBarang = mod.getBarangList();
            list.getUser = mod.getUser();
            return View(list);
        }

        public ActionResult InsertExistAction(spGetBarangBaru_Result brg)
        {
            db.spBarangMasukExist(brg.id_brg, brg.tanggal_msk, brg.jumlah_brg, brg.deskripsi_brg, brg.id_pj);
            return RedirectToAction("Index", new { Area = "Admin" });
        }

        public ActionResult InsertNew()
        {
            if (Session["UserID"] != null)
            {
            list.getKategori = mod.getKategori();
            list.getUser = mod.getUser();
            list.getSupplier = mod.getSupplier();
            return View(list);
            }
            return View("ErrorSession");

        }

        public ActionResult InsertNewAction(spGetBarangBaru_Result brg)
        {
            //db.spBarangMasukNew(brg.id_brg, brg.id_brg, brg.nama_brg, brg.tanggal_msk, brg.deskripsi_brg, brg.kode_brg);
            db.spBarangMasukNew(brg.id_brg, brg.id_sup, brg.id_kat, brg.nama_brg, brg.tanggal_msk, brg.jumlah_brg, brg.deskripsi_brg, brg.id_pj, brg.kode_brg);
            return RedirectToAction("Index", "BrgMasuk", new { Area = "Admin" });
        }

        public ActionResult Delete(int? id)
        {
            if (Session["UserID"] != null)
            {
                BarangMasuk result = db.BarangMasuks.Find(id);
                return View(result);
            }
            return View("ErrorSession");


        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAction(int id)
        {
            BarangMasuk result = db.BarangMasuks.Find(id);
            db.BarangMasuks.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index", "BrgMasuk", new { Area = "Admin" });
        }

    }
}