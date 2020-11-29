using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.BusinessLayer;
using QuanLyThuVien.Entities;


namespace QuanLyThuVien.Presenation
{
    public class frmSach
    {
        private ISachBLL saDLL = new SachBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.Write("NHAP THONG TIN VE SACH");
            Sach sa = new Sach();
            Console.Write("Nhap ten cua sach :"); sa.TenSach = Console.ReadLine();
            Console.Write("Nhap the loai cua sach :"); sa.LoaiSach = Console.ReadLine();
            Console.Write("Nhap thong tin NXB cua sach :"); sa.NhaXuatban = Console.ReadLine();
            Console.Write("Nhap so luong sach con trong thu vien :"); sa.SoLuong = int.Parse(Console.ReadLine());
            saDLL.ThemSach(sa);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("HIEN THI THONG TIN VE SACH");
            List<Sach> list = saDLL.GetAllSach();
            foreach (var sa in list)
                Console.WriteLine(sa.MaSach + "\t" + sa.TenSach + "\t" + sa.LoaiSach + "\t" + sa.NhaXuatban + "\t" + sa.SoLuong);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN VE SACH");
            List<Sach> list = saDLL.GetAllSach();
            string masach;
            Console.Write("Nhap ma san pham can sua :");
            masach = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].MaSach == masach) break;
            if(i < list.Count)
            {
                Sach sa = new Sach(list[i]);
                Console.Write("Nhap ten moi cua sach :");
                string ten = Console.ReadLine();
                if (!string.IsNullOrEmpty(ten)) sa.TenSach = ten;
                Console.Write("Nhap the loai moi cua sach :");
                string loai = Console.ReadLine();
                if (!string.IsNullOrEmpty(loai)) sa.LoaiSach = loai;
                Console.Write("Nhap nha xuat ban moi cua sach :");
                string nxb = Console.ReadLine();
                if (!string.IsNullOrEmpty(nxb)) sa.LoaiSach = nxb;
                Console.Write("So luong moi cua sach :");
                int soluong = int.Parse(Console.ReadLine());
                if (soluong > 0) sa.SoLuong = soluong;
                saDLL.SuaSach(sa);
            }
            else
            {
                Console.WriteLine("khong ton tai ma sach nay !");
            }
        }               
    }
}
