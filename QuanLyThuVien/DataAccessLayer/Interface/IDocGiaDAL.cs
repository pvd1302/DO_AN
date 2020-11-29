using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    public interface IDocGiaDAL
    {
        List<DocGia> GetAllDocGia();
        void ThemDG(DocGia dg);
        void Update(List<DocGia> listdg);
    }
}