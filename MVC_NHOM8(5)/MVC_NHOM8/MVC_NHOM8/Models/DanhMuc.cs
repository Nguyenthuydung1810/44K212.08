using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace MVC_NHOM8.Models
{
    public class DanhMuc
    {
        [Key]
        public int DanhMucID { get; set; }
        public string TenDanhMuc { get; set; }
        public String Mota { get; set; }
        // có quan hệ một nhiều
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}