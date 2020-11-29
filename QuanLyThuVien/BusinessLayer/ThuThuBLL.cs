using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;
using QuanLyThuVien.DataAccessLayer;

namespace QuanLyThuVien.BusinessLayer
{
    public class ThuThuBLL : IThuThuBLL
    {
        private IThuThuDAL ttDA = new ThuThuDAL();
        public List<Thuthu> GetAllThuThu()
        {
            return ttDA.GetAllThuThu();
        }
        public void ThemTT(Thuthu tt)
        {
            if (!string.IsNullOrEmpty(tt.TenThuThu))
            {
                ttDA.ThemTT(tt);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void XoaTT(string matt)
        {
            int i;
            List<Thuthu> listt = GetAllThuThu();
            for (i = 0; i < listt.Count; ++i)
                if (listt[i].MaThuThu == matt) break;
            if (i < listt.Count)
            {
                listt.RemoveAt(i);
                ttDA.Update(listt);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void SuaTT(Thuthu tt)
        {
            int i;
            List<Thuthu> listt = GetAllThuThu();
            for (i = 0; i < listt.Count; ++i)
                if (listt[i].MaThuThu == tt.MaThuThu) break;
            if (i < listt.Count)
            {
                listt.RemoveAt(i);
                listt.Add(tt);
                ttDA.Update(listt);
            }
            else
                throw new Exception("Khong ton tai thu thu nay");
        }
        public List<Thuthu> TimTT(Thuthu tt)
        {
            List<Thuthu> listt = GetAllThuThu();
            List<Thuthu> kq = new List<Thuthu>();
            if (string.IsNullOrEmpty(tt.MaThuThu) &&
                string.IsNullOrEmpty(tt.TenThuThu)
                )
            {
                kq = listt;
            }
            // Tim theo ten thu thu
            if (!string.IsNullOrEmpty(tt.TenThuThu))
            {
                for (int i = 0; i < listt.Count; ++i)
                    if (listt[i].TenThuThu.IndexOf(tt.TenThuThu) >= 0)
                    {
                        kq.Add(new Thuthu(listt[i]));
                    }
            }

            // Tim theo ma thu thu
            else if (!string.IsNullOrEmpty(tt.MaThuThu))
            {
                for (int i = 0; i < listt.Count; ++i)
                    if (listt[i].MaThuThu.IndexOf(tt.MaThuThu) >= 0)
                    {
                        kq.Add(new Thuthu(listt[i]));
                    }
            }
            else kq = null;
            return kq;
        }

    }
}
