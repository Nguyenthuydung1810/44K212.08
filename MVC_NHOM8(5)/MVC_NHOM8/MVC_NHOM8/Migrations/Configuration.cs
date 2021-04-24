namespace MVC_NHOM8.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_NHOM8.Models.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVC_NHOM8.Models.ProductDBContext";
        }

        protected override void Seed(MVC_NHOM8.Models.ProductDBContext context)
        {
            context.DanhMucs.AddOrUpdate(c => c.DanhMucID,
                new Models.DanhMuc { DanhMucID = 1, TenDanhMuc = @"Gạch", Mota = @"" },
        new Models.DanhMuc { DanhMucID = 2, TenDanhMuc = @"Xi Măng", Mota = @"" },
         new Models.DanhMuc { DanhMucID = 3, TenDanhMuc = @"Thiết bị ngành nước", Mota = @"" },
          new Models.DanhMuc { DanhMucID = 4, TenDanhMuc = @"Thiết bị ngành điện", Mota = @"" },
           new Models.DanhMuc { DanhMucID = 5, TenDanhMuc = @"Cát", Mota = @"" }
        );
            context.SanPhams.AddOrUpdate(p => p.SanPhamID,
                new Models.SanPham { SanPhamID = 1, TenSP = @"Gạch 6 lỗ", AnhSP = " ", SoLuongSP = 7000, GiaSP = 2500, MotaSP = @"THÔNG TIN SẢN PHẨM:Kích cỡ: 250x250mm. Chủng loại: Gạch men bóng", DanhMucID = 1 },
                new Models.SanPham { SanPhamID = 2, TenSP = @"Gạch đất nung", AnhSP = " ", SoLuongSP = 8500, GiaSP = 2000, MotaSP = @"THÔNG TIN SẢN PHẨM:Kích cỡ: 300 x 300 x16 mm. Chủng loại: gạch đỏ truyền thống", DanhMucID = 1 },
                new Models.SanPham { SanPhamID = 3, TenSP = @"Gạch bông", AnhSP = " ", SoLuongSP = 400, GiaSP = 8600, MotaSP = @"THÔNG TIN SẢN PHẨM:Kích cỡ: 300 x 300 x16 mm. Chủng loại: Gạch ceramic men", DanhMucID = 1 },
                new Models.SanPham { SanPhamID = 4, TenSP = @"Van một chiều", AnhSP = " ", SoLuongSP = 10, GiaSP = 25000, MotaSP = @"THÔNG TIN SẢN PHẨM:Van một chiều ren đồng, lá lật. Sản xuất theo tiêu chuẩn BS 5154:1991", DanhMucID = 3 },
                new Models.SanPham { SanPhamID = 5, TenSP = @"Van bi tay dài", AnhSP = " ", SoLuongSP = 60, GiaSP = 49000, MotaSP = @"THÔNG TIN SẢN PHẨM:Vật liệu: Đồng mạ crom. Đường ren tiêu chuẩn BS 21 / ISO 228-1-2000", DanhMucID = 3 },
                new Models.SanPham { SanPhamID = 6, TenSP = @"Ổ cắm HQ", AnhSP = " ", SoLuongSP = 8, GiaSP = 25000, MotaSP = @"THÔNG TIN SẢN PHẨM:Chủng loại: HQ (không màng che)", DanhMucID = 4 },
                new Models.SanPham { SanPhamID = 7, TenSP = @"Xi măng Hà Tiên", AnhSP = " ", SoLuongSP = 100, GiaSP = 79000, MotaSP = @"THÔNG TIN SẢN PHẨM:Xi măng Hà Tiên Portland hỗn hợp PCB 40", DanhMucID = 2 },
                new Models.SanPham { SanPhamID = 8, TenSP = @"Cát xây tô", AnhSP = " ", SoLuongSP = 100, GiaSP = 79000, MotaSP = @"THÔNG TIN SẢN PHẨM:Xi măng Hà Tiên Portland hỗn hợp PCB 40", DanhMucID = 2 }
                );
            context.KhachHangs.AddOrUpdate(d => d.KhachHangID,
                new Models.KhachHang
                {
                    KhachHangID = 1,
                    TenKH = @"Nguyễn Thùy Dung",
                    DiaChiKH = @"07 Trường Sơn Đà Nẵng",
                    EmailKH = @"nguyenthuydung1810@gmail.com",
                    SdtKH = "0905957700",

                },
                new Models.KhachHang
                {
                    KhachHangID = 2,
                    TenKH = @"Thái Thị Thanh Trúc",
                    DiaChiKH = @"89 Quang Trung Đà Nẵng",
                    EmailKH = @"tructtt04@gmail.com",
                    SdtKH = "0905123456"
                },
                new Models.KhachHang
                {
                    KhachHangID = 3,
                    TenKH = @"Nguyễn Phú Minh Trí",
                    DiaChiKH = @"65 Lê Lợi Đà Nẵng",
                    EmailKH = @"trimn06@gmail.com",
                    SdtKH = "0905123897"
                }
                );
            context.DonDatHangs.AddOrUpdate(a => a.DonDatHangID,
                new Models.DonDatHang
                {
                    DonDatHangID = 1,
                    NgayTao = DateTime.Parse("2019-12-02"),
                    ThanhTien = 12340000,
                    TinhTrangDonHang = @"Thanh toán qua ngân hàng",
                    KhachHangID = 1,
                    TenKH = @"Nguyen Thuy Dung",
                    SdtKH = "0905957700",
                    EmailKH = "nguyenthuydung1810@gmail.com"

                }
                );
            context.ChiTietDonDatHangs.AddOrUpdate(v => v.ChiTietDDHID,
                new Models.ChiTietDonDatHang
                {
                    ChiTietDDHID = 1,
                    DonDatHangID = 1,
                    SoLuong = 4,
                    SanPham = @"Gạch 6 lỗ",
                    DonGia = 79000,
                    SanPhamID = 1
                }
                );
            context.QuyenDangNhaps.AddOrUpdate(m => m.QuyenDNID,
                new Models.QuyenDangNhap
                {
                    QuyenDNID = 1,
                    TenQuyenDN = "admin"
                }
                );
            context.USERs.AddOrUpdate(n => n.UserID,
                new Models.USER
                {
                    UserID = 1,
                    TenDangNhap = "nhinemn",
                    MatKhau = "nhi123",
                    EmailDK = "nhi@gmail.com",
                    DiaChiDK = "Da Nang",
                    TenDayDu = @"Hồ Thị Yến Nhi",
                    Cauhoibaomat = @"Sở thích của bạn là gì?",
                    NgaySinh = DateTime.Parse("2000-04-02"),
                    GioiTinh = @"Nữ",
                    QuyenDNID = 1,
                }
                );
        }
    }
}
