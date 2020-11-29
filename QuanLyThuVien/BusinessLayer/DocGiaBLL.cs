using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;
using QuanLyThuVien.DataAccessLayer;

namespace QuanLyThuVien.BusinessLayer
{
    public class DocGiaBLL : IDocGiaBLL
    {
        private IDocGiaDAL dgDA = new DocGiaDAL();
        public List<DocGia> GetAllDocGia()
        {
            return dgDA.GetAllDocGia();
        }
        public void ThemDG(DocGia dg)
        {
            if (!string.IsNullOrEmpty(dg.TenDocgia))
            {
                dgDA.ThemDG(dg);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void XoaDG(string madg)
        {
            int i;
            List<DocGia> listdg = GetAllDocGia();
            for (i = 0; i < listdg.Count; ++i)
                if (listdg[i].MaDocGia == madg) break;
            if (i < listdg.Count)
            {
                listdg.RemoveAt(i);
                dgDA.Update(listdg);
            }
            else
                throw new Exception("Khong ton tai ma doc gia nay");
        }

        public void SuaDG(DocGia dg)
        {
            int i;
            List<DocGia> listdg = GetAllDocGia();
            for (i = 0; i < listdg.Count; ++i)
                if (listdg[i].MaDocGia == dg.MaDocGia) break;
            if (i < listdg.Count)
            {
                listdg.RemoveAt(i);
                listdg.Add(dg);
                dgDA.Update(listdg);
            }
            else
                throw new Exception("Khong ton tai ma doc gia nay");
        }

        public List<DocGia> TimDG(DocGia dg)
        {
            List<DocGia> listdg = GetAllDocGia();
            List<DocGia> kq = new List<DocGia>();
            if (string.IsNullOrEmpty(dg.MaDocGia) &&
                string.IsNullOrEmpty(dg.TenDocgia)
                )
            {
                kq = listdg;
            }
            // Tim theo ten doc gia
            if (!string.IsNullOrEmpty(dg.TenDocgia))
            {
                for (int i = 0; i < listdg.Count; ++i)
                    if (listdg[i].TenDocgia.IndexOf(dg.TenDocgia) >= 0)
                    {
                        kq.Add(new DocGia(listdg[i]));
                    }
            }

            // Tim theo ma doc gia
            else if (!string.IsNullOrEmpty(dg.MaDocGia))
            {
                for (int i = 0; i < listdg.Count; ++i)
                    if (listdg[i].MaDocGia.IndexOf(dg.MaDocGia) >= 0)
                    {
                        kq.Add(new DocGia(listdg[i]));
                    }
            }
            else kq = null;
            return kq;
        }
    }
}