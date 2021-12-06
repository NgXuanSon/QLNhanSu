using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLNhanSu.Models
{
    
        [Table("KyLuats")]
        public class KyLuat
        {
            [Key]
            [Display(Name = "Tên nhân viên")]
            public string TenNV { get; set; }
            [Display(Name = "Loại kỷ luật")]
            public string LoaiKyLuat { get; set; }
            [Display(Name = "Mức độ kỷ luật")]
            public string MucDoKyLuat { get; set; }
            [Display(Name = "Lý do")]
            public string LyDo { get; set; }
            [Display(Name = "Loại hình phạt")]
            public string LoaiHinhPhat { get; set; }
            public  NhanVien NhanViens { get; set; }
        }
}