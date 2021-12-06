using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLNhanSu.Models
{
    
        [Table("ChamCongs")]
        public class ChamCong
        {
            [Key]
            [Display(Name = "Tên nhân viên")]
            public string TenNV { get; set; }
            [Display(Name = "Số ngày làm")]
            public int SoNgayLam { get; set; }
            [Display(Name = "Số ngày nghỉ")]
            public int SoNgayNghi { get; set; }
            [Display(Name = "Lý do nghỉ")]
            public string LyDoNghi { get; set; }
            public  NhanVien NhanViens { get; set; }
        }
}