using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    class ThuThuDAL : IThuThuDAL
    {
        //Duong dan luu du lieu tep ThuThu.txt
        private string txtfile = "Data/ThuThu.txt";

        //Lay du lieu co trong file
        public List<Thuthu> GetAllThuThu()
        {
            List<Thuthu> list = new List<Thuthu>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if(s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new Thuthu(a[0], a[1], a[2], a[3], a[4], int.Parse(a[5]), int.Parse(a[6])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemTT(Thuthu tt)
        {
            string matt = "TT" + DateTime.Now.ToString("yyMMdd");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(matt + "#" + tt.TenThuThu + "#" + tt.NgaySinhThuThu + "#" + tt.GioiTinhThuThu + "#" + tt.DiaChithuthu + "#" + tt.SDTThuThu + "#" + tt.CMNDthuThu);
            fwrite.Close();
        }
        public void Update(List<Thuthu> listt)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < listt.Count; ++i)
                fwrite.WriteLine(listt[i].MaThuThu + "#" + listt[i].TenThuThu + "#" + listt[i].NgaySinhThuThu + "#" + listt[i].GioiTinhThuThu + "#" + listt[i].DiaChithuthu + "#" + listt[i].SDTThuThu + "#" + listt[i].CMNDthuThu);
            fwrite.Close();
        }
    }   
}
