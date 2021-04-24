using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_NHOM8.Models
{
    public class KhachHang
    {
        [Key]
        public int KhachHangID { get; set; }
        public string TenKH { get; set; }
        public string DiaChiKH { get; set; }
        public string SdtKH { get; set; }
        public string EmailKH { get; set; }
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}