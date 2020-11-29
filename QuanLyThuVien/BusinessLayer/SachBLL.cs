using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;
using QuanLyThuVien.DataAccessLayer;

namespace QuanLyThuVien.BusinessLayer
{
    public class SachBLL : ISachBLL
    {
        private ISachDAL saDA = new SachDAL();
        public List<Sach> GetAllSach()
        {
            return saDA.GetAllSach();
        }   
        public void ThemSach(Sach sa)
        {
            if (!string.IsNullOrEmpty(sa.TenSach))
            {
                saDA.ThemSach(sa);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaSach(string masach)
        {
            int i;
            List<Sach> listsa = GetAllSach();
            for (i = 0; i < listsa.Count; ++i)
                if (listsa[i].MaSach == masach) break;
            if (i < listsa.Count)
            {
                listsa.RemoveAt(i);
                saDA.Update(listsa);
            }
            else
                throw new Exception("Khong ton tai ma sach nay");
        }
        public void SuaSach(Sach sa)
        {
            int i;
            List<Sach> listsa = GetAllSach();
            for(i = 0; i < listsa.Count; ++i)
                if (listsa[i].MaSach == sa.MaSach) break;
            if (i < listsa.Count)
            {
                listsa.RemoveAt(i);
                listsa.Add(sa);
                saDA.Update(listsa);
            }
            else
                throw new Exception("Khong ton tai sach nay");
        }
        public List<Sach> TimSach(Sach sa)
        {
            List<Sach> listsa = GetAllSach();
            List<Sach> kq = new List<Sach>();
            if(string.IsNullOrEmpty(sa.MaSach)   &&
                string.IsNullOrEmpty(sa.TenSach) &&
                sa.SoLuong == 0)
            {
                kq = listsa;
            }

            // Tim kiem theo ten sach
            if (!string.IsNullOrEmpty(sa.TenSach))
            {
                for(int i = 0; i < listsa.Count; ++i)
                    if (listsa[i].TenSach.IndexOf(sa.TenSach) >= 0)
                    {
                        kq.Add(new Sach(listsa[i]));
                    }
            }

            // Tim theo ma sach
            if (!string.IsNullOrEmpty(sa.MaSach))
            {
                for (int i = 0; i < listsa.Count; ++i)
                    if (listsa[i].MaSach.IndexOf(sa.MaSach) >= 0)
                    {
                        kq.Add(new Sach(listsa[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}
