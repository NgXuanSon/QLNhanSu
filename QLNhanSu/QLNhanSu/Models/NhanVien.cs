using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLNhanSu.Models
{
    
        [Table("NhanViens")]
        public class NhanVien
        {
            [Key]
            [Display(Name = "Mã nhân viên")]
            public string IDNV { get; set; }
            [StringLength(50)]
            [Display(Name = "Tên nhân viên")]
            public string TenNV { get; set; }
            [Display(Name = "Năm sinh")]
            public string Namsinh { get; set; }
            [Display(Name = "Giới tính")]
            public string GioiTinh { get; set; }

            [Display(Name = "Số điện thoại")]
            public string SDT { get; set; }
            [StringLength(100)]
            public string Email { get; set; }
            [StringLength(255)]
            [Display(Name = "Địa chỉ")]
            public string DiaChi { get; set; }
            public string MaPB { get; set; }
            public string IDChucVu { get; set; }

            public ChucVu ChucVu { get; set; }
            public PhongBan PhongBan { get; set; }

             public  ICollection<BangLuong> BangLuongs { get; set; }
            public  ICollection<ChamCong> ChamCongs { get; set; }
            public  ICollection<KhenThuong> KhenThuongs { get; set; }
            public  ICollection<KyLuat> KyLuat { get; set; }
        }
}