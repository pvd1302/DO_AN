using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    class PhieuMuonDAL : IPhieuMuonDAL
    {

        //Duong dan du lieu tep PhieMuon.txt
        private string txtfile = "Data/PhieuMuon.txt";

        //Lay du lieu trong file
        public List<PhieuMuon> GetAllPhieuMuon()
        {
            List<PhieuMuon> list = new List<PhieuMuon>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while( s!= null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new PhieuMuon(a[0], int.Parse(a[1]), a[2], int.Parse(a[3])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemPhieu(PhieuMuon pm, Sach sa, DocGia dg, Thuthu tt)
        {
            string maphieu = "PM" + DateTime.Now.ToString("yyMMdd");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(maphieu + "#" + dg.MaDocGia + "#" + sa.MaSach + "#" + pm.SoLuongMuon + "#" + pm.NgayMuon + "#" + pm.ThoiGianMuon + "#" + tt.MaThuThu);
            fwrite.Close();
        }
        public void Update(List<PhieuMuon> listpm, List<Sach> listsa, List<DocGia> listdg, List<Thuthu> listt)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < listpm.Count; ++i)
                fwrite.WriteLine(listpm[i].MaPhieuMuon + "#" + listdg[i].MaDocGia + "#" + listsa[i].MaSach + "#" + listpm[i].SoLuongMuon + "#" + listpm[i].NgayMuon + "#" + listpm[i].ThoiGianMuon + "#" + listt[i].MaThuThu);
            fwrite.Close();
        }
    }
}
