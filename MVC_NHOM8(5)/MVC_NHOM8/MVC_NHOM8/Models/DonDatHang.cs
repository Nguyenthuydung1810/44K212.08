using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace MVC_NHOM8.Models
{
    public class DonDatHang
    {
        [Key]
        public int DonDatHangID { get; set; }
        public DateTime NgayTao { get; set; }
        public double ThanhTien { get; set; }
        public string TinhTrangDonHang { get; set; }
        public int KhachHangID { get; set; }
        public string TenKH { get; set; }
        public string SdtKH { get; set; }
        public string EmailKH { get; set; }
        public virtual KhachHang KhachHangs { get; set; }
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
    }
}