using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.BusinessLayer
{
    public interface IThuThuBLL
    {
        List<Thuthu> GetAllThuThu();
        void ThemTT(Thuthu tt);
        void XoaTT(string matt);
        void SuaTT(Thuthu tt);
        List<Thuthu> TimTT(Thuthu tt);
    }
}
