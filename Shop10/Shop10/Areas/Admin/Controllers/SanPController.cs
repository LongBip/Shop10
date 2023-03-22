using Shop10.Models.BUS;
using ShopOnlineConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop10.Areas.Admin.Controllers
{
    public class SanPController : Controller
    {
        // GET: Admin/SanP
        public ActionResult Index()
        {
            return View(Shop10BUS.DanhSachSP());
        }


        // GET: Admin/SanP/Create
        public ActionResult Create()
        {
            ViewBag.MaNhaSanXuat = new SelectList(NhaSanXuatBUS.DanhSach(), "MaNhaSanXuat", "TenNhaSanXuat");
            //ViewBag.MaLoaiSanPham = new SelectList(NhaSanXuatBUS.DanhSach(), "MaLoaiSanPham", "TenLoaiSanPham");

            return View();
        }

        // POST: Admin/SanP/Create
        [HttpPost]
        public ActionResult Create(SanPham sp)
        {
            try
            {
                // TODO: Add insert logic here
                Shop10BUS.InsertSP(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
         
        // GET: Admin/SanP/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: Admin/SanP/Edit/5
        //[HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanP/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/SanP/Delete/5
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
