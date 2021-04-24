using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;


namespace MVC_NHOM8.Models
{
    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext()
            : base("name=ProductDBContext")
        {
        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<DonDatHang> DonDatHangs { get; set; }
        public DbSet<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public DbSet<USER> USERs { get; set; }
        public DbSet<QuyenDangNhap> QuyenDangNhaps { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}