using Shop10.Models.BUS;
using ShopOnlineConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop10.Areas.Admin.Controllers
{
    public class NhaSXController : Controller
    {
        // GET: Admin/NhaSX
        public ActionResult Index()
        {
            var ds = NhaSanXuatBUS.DanhSachAdmin();
            return View(ds);
        }

        // GET: Admin/NhaSX/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/NhaSX/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NhaSX/Create
        [HttpPost]
        public ActionResult Create(NhaSanXuat nsx)
        {
            try
            {
                // TODO: Add insert logic here
                NhaSanXuatBUS.ThemNSX(nsx);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/NhaSX/Edit/5
        public ActionResult Edit(String id)
        {
            return View(NhaSanXuatBUS.ChiTietAdmin(id));
        }

        // POST: Admin/NhaSX/Edit/5
        [HttpPost]
        public ActionResult Edit(String id, NhaSanXuat nsx)
        {
            try
            {
                // TODO: Add update logic here
                NhaSanXuatBUS.UpdateNSX(id, nsx);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult XoaTamThoi(String id)
        {
            return View(NhaSanXuatBUS.ChiTietAdmin(id));
        }
        [HttpPost]
        public ActionResult XoaTamThoi(String id, NhaSanXuat nsx)
        {
            try
            {
                // TODO: Add delete logic here
                nsx.TinhTrang = "1";
                NhaSanXuatBUS.UpdateNSX(id, nsx);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Admin/NhaSX/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/NhaSX/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
