using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    class DocGiaDAL : IDocGiaDAL
    {
        //Duong dan luu du lieu tep DocGia.txt
        private string txtfile = "Data/DocGia.txt";

        //lay du lieu trong file
        public List<DocGia> GetAllDocGia()
        {
            List<DocGia> list = new List<DocGia>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new DocGia(a[0], a[1], a[2], a[3], a[4], int.Parse(a[5]), int.Parse(a[6])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemDG(DocGia dg)
        {
            string madg = "DG" + DateTime.Now.ToString("yyMMdd");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(madg + "#" + dg.TenDocgia + "#" + dg.NgaySinhDocGia + "#" + dg.GioiTinhDocGia + "#" + dg.DiaChiDocGia + "#" + dg.SDTDocGia + "#" + dg.CMNDDocGia);
            fwrite.Close();
        }
        public void Update(List<DocGia> listdg)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < listdg.Count; ++i)
                fwrite.WriteLine(listdg[i].MaDocGia + "#" + listdg[i].TenDocgia + "#" + listdg[i].NgaySinhDocGia + "#" + listdg[i].GioiTinhDocGia + "#" + listdg[i].DiaChiDocGia + "#" + listdg[i].SDTDocGia + "#" + listdg[i].CMNDDocGia);
            fwrite.Close();
        }
    }
}
