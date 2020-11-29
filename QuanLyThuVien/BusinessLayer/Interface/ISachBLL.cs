using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.BusinessLayer
{
    public interface ISachBLL
    {
        List<Sach> GetAllSach();
        void ThemSach(Sach sa);
        void XoaSach(string masach);
        void SuaSach(Sach sa);
        List<Sach> TimSach(Sach sa);
    }
}
