using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_NHOM8.Models
{
    public class USER
    {
        [Key]
        public int UserID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string EmailDK { get; set; }
        public string DiaChiDK { get; set; }
        public string TenDayDu { get; set; }
        public string Cauhoibaomat { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public int QuyenDNID { get; set; }
        public virtual QuyenDangNhap QuyenDangNhaps { get; set; }


    }
}