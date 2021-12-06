namespace QLNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinhVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BangLuongs",
                c => new
                    {
                        TenNV = c.String(nullable: false, maxLength: 128),
                        Luong = c.String(),
                        Phucap = c.String(),
                        NhanViens_IDNV = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TenNV)
                .ForeignKey("dbo.NhanViens", t => t.NhanViens_IDNV)
                .Index(t => t.NhanViens_IDNV);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        IDNV = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(maxLength: 50),
                        Namsinh = c.String(),
                        GioiTinh = c.String(),
                        SDT = c.String(),
                        Email = c.String(maxLength: 100),
                        DiaChi = c.String(maxLength: 255),
                        MaPB = c.String(maxLength: 10),
                        IDChucVu = c.String(),
                        ChucVu_TenPB = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IDNV)
                .ForeignKey("dbo.ChucVus", t => t.ChucVu_TenPB)
                .ForeignKey("dbo.PhongBans", t => t.MaPB)
                .Index(t => t.MaPB)
                .Index(t => t.ChucVu_TenPB);
            
            CreateTable(
                "dbo.ChamCongs",
                c => new
                    {
                        TenNV = c.String(nullable: false, maxLength: 128),
                        SoNgayLam = c.Int(nullable: false),
                        SoNgayNghi = c.Int(nullable: false),
                        LyDoNghi = c.String(),
                        NhanViens_IDNV = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TenNV)
                .ForeignKey("dbo.NhanViens", t => t.NhanViens_IDNV)
                .Index(t => t.NhanViens_IDNV);
            
            CreateTable(
                "dbo.ChucVus",
                c => new
                    {
                        TenPB = c.String(nullable: false, maxLength: 128),
                        IDChucVu = c.String(maxLength: 10),
                        TenChucVu = c.String(),
                        LuongCoBan = c.String(),
                        PhongBans_MaPB = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.TenPB)
                .ForeignKey("dbo.PhongBans", t => t.PhongBans_MaPB)
                .Index(t => t.PhongBans_MaPB);
            
            CreateTable(
                "dbo.PhongBans",
                c => new
                    {
                        MaPB = c.String(nullable: false, maxLength: 10),
                        TenPB = c.String(),
                    })
                .PrimaryKey(t => t.MaPB);
            
            CreateTable(
                "dbo.KyLuats",
                c => new
                    {
                        TenNV = c.String(nullable: false, maxLength: 128),
                        LoaiKyLuat = c.String(),
                        MucDoKyLuat = c.String(),
                        LyDo = c.String(),
                        LoaiHinhPhat = c.String(),
                        NhanViens_IDNV = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TenNV)
                .ForeignKey("dbo.NhanViens", t => t.NhanViens_IDNV)
                .Index(t => t.NhanViens_IDNV);
            
            CreateTable(
                "dbo.KhenThuongs",
                c => new
                    {
                        TenNV = c.String(nullable: false, maxLength: 128),
                        DanhHieuKhenthuong = c.String(),
                        MaSoKhenThuong = c.String(),
                        TienThuong = c.String(),
                        NhanViens_IDNV = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TenNV)
                .ForeignKey("dbo.NhanViens", t => t.NhanViens_IDNV)
                .Index(t => t.NhanViens_IDNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "MaPB", "dbo.PhongBans");
            DropForeignKey("dbo.KhenThuongs", "NhanViens_IDNV", "dbo.NhanViens");
            DropForeignKey("dbo.KyLuats", "NhanViens_IDNV", "dbo.NhanViens");
            DropForeignKey("dbo.NhanViens", "ChucVu_TenPB", "dbo.ChucVus");
            DropForeignKey("dbo.ChucVus", "PhongBans_MaPB", "dbo.PhongBans");
            DropForeignKey("dbo.ChamCongs", "NhanViens_IDNV", "dbo.NhanViens");
            DropForeignKey("dbo.BangLuongs", "NhanViens_IDNV", "dbo.NhanViens");
            DropIndex("dbo.KhenThuongs", new[] { "NhanViens_IDNV" });
            DropIndex("dbo.KyLuats", new[] { "NhanViens_IDNV" });
            DropIndex("dbo.ChucVus", new[] { "PhongBans_MaPB" });
            DropIndex("dbo.ChamCongs", new[] { "NhanViens_IDNV" });
            DropIndex("dbo.NhanViens", new[] { "ChucVu_TenPB" });
            DropIndex("dbo.NhanViens", new[] { "MaPB" });
            DropIndex("dbo.BangLuongs", new[] { "NhanViens_IDNV" });
            DropTable("dbo.KhenThuongs");
            DropTable("dbo.KyLuats");
            DropTable("dbo.PhongBans");
            DropTable("dbo.ChucVus");
            DropTable("dbo.ChamCongs");
            DropTable("dbo.NhanViens");
            DropTable("dbo.BangLuongs");
        }
    }
}
