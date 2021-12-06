using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLNhanSu.Models
{
    [Table("KhenThuongs")]
    public class KhenThuong
    {

        [Key]
        [Display(Name = "Tên nhân viên")]
        public string TenNV { get; set; }
        [Display(Name = "Danh hiệu khen thưởng")]
        public string DanhHieuKhenthuong { get; set; }
        [Display(Name = "Mã số khen thưởng")]
        public string MaSoKhenThuong { get; set; }
        [Display(Name = "Tiền thưởng")]
        public string TienThuong { get; set; }
        public  NhanVien NhanViens { get; set; }
    }
}