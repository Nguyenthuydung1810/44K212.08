using NHOM8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_NHOM8.Models.BUS
{
    public class sanpham_bus
    {
        public static IEnumerable<NHOM8.SanPham> DanhSach()
        {
            var db = new NHOM8DB();
            return db.Query<NHOM8.SanPham>("select * from SanPhams where DanhMucID = '3'");

        }
        public static NHOM8.SanPham ChiTiet(string a)
        {
            var db = new NHOM8DB();
            return db.SingleOrDefault<NHOM8.SanPham>("select * from SanPhams where SanPhamID = @0", a);

        }
        //---------------- Admin
        public static void ThemSP(SanPham sp)
        {
            var db = new NHOM8DB();
            db.Insert(sp);
        }
        public static IEnumerable<SanPham> DanhSachAdmin()
        {
            var db = new NHOM8DB();
            return db.Query<NHOM8.SanPham>("select * from SanPhams");
        }
        public static NHOM8.SanPham ChiTietAdmin(String id)
        {
            var db = new NHOM8DB();
            return db.SingleOrDefault<NHOM8.SanPham>("select * from SanPhams where SanPhamID = '" + id + "'");

        }

        public static void UpdateSP(String id, NHOM8.SanPham sp)
        {
            var db = new NHOM8DB();
            db.Update(sp, id);
        }
    }
}