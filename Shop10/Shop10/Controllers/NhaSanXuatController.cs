using PagedList;
using Shop10.Models.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop10.Controllers
{
    public class NhaSanXuatController : Controller
    {
        // GET: NhaSanXuat
     
        public ActionResult Index(String id,int page = 1, int pagesize = 6)
        {
            var ds = NhaSanXuatBUS.ChiTiet(id).ToPagedList(page, pagesize);
            return View(ds);
        }
    }
}