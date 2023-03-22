using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopOnlineConection;


namespace Shop10.Models.BUS
{
    public class Shop10BUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopOnlineConectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");
        }
        public static SanPham ChiTiet(String a)
        {
            var db = new ShopOnlineConectionDB();
            return db.SingleOrDefault<SanPham>("select * from SanPham where MaSanPham =@0", a);
        }
        public static IEnumerable<SanPham> Top4New()
        {
            var db = new ShopOnlineConectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where GhiChu =N'New'");
        }
        public static IEnumerable<SanPham> TopHot()
        {
            var db = new ShopOnlineConectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where LuotView >0");
        }
        //...................................
        public static IEnumerable<SanPham> DanhSachSP()
        {
            var db = new ShopOnlineConectionDB();
            return db.Query<SanPham>("select * from SanPham");
        }
        public static void InsertSP(SanPham sp)
        {
            var db = new ShopOnlineConectionDB();
            db.Insert(sp);
        }
    }
}