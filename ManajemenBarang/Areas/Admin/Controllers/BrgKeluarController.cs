using ManajemenBarang.Areas.Admin.Models;
using ManajemenBarang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManajemenBarang.Areas.Admin.Controllers
{
    public class BrgKeluarController : Controller
    {
        BarangClass mod = new BarangClass();
        private dbStokEntities db = new dbStokEntities();
        ListOptions list = new ListOptions();
        // GET: Admin/BarangKeluar
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                List<spGetBarangKeluarJoin_Result> result = mod.getBarangKeluar();
                return View(result);
            }
            return View("ErrorSession");
            
        }

        //public ActionResult BarangKeluar()
        //{
        //    List<spGetBarangKeluarJoin_Result> result = mod.getBarangKeluar();
        //    return View(result);
        //}

        public ActionResult Insert()
        {
            if (Session["UserID"] != null)
            {
                list.getBarang = mod.getBarangList();
                list.getUser = mod.getUser();
                return View(list);
            }
            return View("ErrorSession");
            
        }

        public ActionResult InsertAction(spGetBarangKeluar_Result brg)
        {
            db.spBarangKeluar(brg.id_barang, brg.tanggal_keluar, brg.jum_barang_keluar, brg.deskripsi, brg.created_by);
            return RedirectToAction("Index", new { Area = "Admin" });
        }

        public ActionResult Delete(int? id)
        {
            '
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAction(int id)
        {
            BarangKeluar result = db.BarangKeluars.Find(id);
            db.BarangKeluars.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index","BrgKeluar", new { Area = "Admin" });
        }
    }
}