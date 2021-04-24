using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_NHOM8.Models
{
    public class SanPham
    {
        [Key]
        public int SanPhamID { get; set; }
        public String TenSP { get; set; }
        public string AnhSP { get; set; }
        public int SoLuongSP { get; set; }
        public float GiaSP { get; set; }
        public String MotaSP { get; set; }
        public String DVT { get; set; }
        public int DanhMucID { get; set; }


        // có quan hệ nhiều một
        public virtual DanhMuc DanhMucs { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
    }
}