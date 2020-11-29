using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    class SachDAL : ISachDAL
    {
        //Duong dan du lieu tep Sach.txt
        private string txtfile = "Data/sach.txt";

        //Lay du lieu co trong file
        public List<Sach> GetAllSach()
        {
            List<Sach> list = new List<Sach>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Sach(a[0], a[1], a[2], a[3], int.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemSach(Sach sa)
        {
            string masach = "SA" + DateTime.Now.ToString("yyMMdd");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(masach + "#" + sa.TenSach + "#" + sa.LoaiSach + "#" + sa.NhaXuatban + "#" + sa.SoLuong);
            fwrite.Close();
        }
        public void Update(List<Sach> listsa)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < listsa.Count; ++i)
                fwrite.WriteLine(listsa[i].MaSach + "#" + listsa[i].TenSach + "#" + listsa[i].LoaiSach + "#" + listsa[i].NhaXuatban + "#" + listsa[i].SoLuong);
            fwrite.Close();
        }
    }
}
