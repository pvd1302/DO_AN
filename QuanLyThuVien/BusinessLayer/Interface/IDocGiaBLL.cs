using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.BusinessLayer
{
    public interface IDocGiaBLL
    {
        List<DocGia> GetAllDocGia();
        void ThemDG(DocGia dg);
        void XoaDG(string madg);
        void SuaDG(DocGia dg);
        List<DocGia> TimDG(DocGia dg);       
    }
}
