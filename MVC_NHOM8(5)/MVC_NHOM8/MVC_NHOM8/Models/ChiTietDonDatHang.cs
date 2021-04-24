using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_NHOM8.Models
{
    public class ChiTietDonDatHang
    {
        [Key]
        public int ChiTietDDHID { get; set; }
        public int DonDatHangID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public string SanPham { get; set; }
        public float DonGia { get; set; }
        public virtual DonDatHang DonDatHangs { get; set; }
        public virtual SanPham SanPhams { get; set; }
    }
}