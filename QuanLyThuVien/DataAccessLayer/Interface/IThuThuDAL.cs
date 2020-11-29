using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    public interface IThuThuDAL
    {
        List<Thuthu> GetAllThuThu();
        void ThemTT(Thuthu tt);
        void Update(List<Thuthu> list);
    }
}