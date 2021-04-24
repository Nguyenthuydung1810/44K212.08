using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_NHOM8.Models
{
    public class QuyenDangNhap
    {
        [Key]
        public int QuyenDNID { get; set; }
        public string TenQuyenDN { get; set; }
        public virtual ICollection<USER> USERs { get; set; }
    }
}