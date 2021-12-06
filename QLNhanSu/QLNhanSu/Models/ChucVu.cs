using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLNhanSu.Models
{
   
        [Table("ChucVus")]
        public class ChucVu
        {
            [Key]
            [Display(Name = "Tên phòng ban")]
            public string TenPB { get; set; }
            [StringLength(10)]
            [Display(Name = "Mã chức vụ")]
            public string IDChucVu { get; set; }
            [Display(Name = "Tên chức vụ")]
            public string TenChucVu { get; set; }
            public string LuongCoBan { get; set; }
        
            public virtual PhongBan PhongBans { get; set; }
        }
}