
using ShopOnlineConection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop10.Models.BUS
{
    public class NhaSanXuatBUS
    { //---------------Khách---------------------
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var db = new ShopOnlineConectionDB();
            return db.Query<NhaSanXuat>("select * from NhaSanXuat where TinhTrang =0");
        }
       
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopOnlineConectionDB();
            return db.Query<SanPham>("select * from SanPham where MaNhaSanXuat = '" + id + "'");
        }
        //-----------------admin-----------------------
        public static IEnumerable<NhaSanXuat> DanhSachAdmin()
        {
            var db = new ShopOnlineConectionDB();
            return db.Query<NhaSanXuat>("select * from NhaSanXuat");
        }
        public static void ThemNSX(NhaSanXuat nsx)
        {
            var db = new ShopOnlineConectionDB();
            db.Insert(nsx);

        }
        public static NhaSanXuat ChiTietAdmin(String id)
        {
            var db = new ShopOnlineConectionDB();
            return db.SingleOrDefault<NhaSanXuat>("select * from NhaSanXuat where MaNhaSanXuat = '" + id + "'");
        }
        public static void UpdateNSX(String id,NhaSanXuat nsx)
        {
            var db = new ShopOnlineConectionDB();
            db.Update(nsx, id);
        }
    }
}