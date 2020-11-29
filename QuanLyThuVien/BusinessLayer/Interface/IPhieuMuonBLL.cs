using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.BusinessLayer
{
    public interface IPhieuMuonBLL
    {
        List<PhieuMuon> GetAllPhieuMuon();
        void ThemPhieu(PhieuMuon pm, Sach sa, DocGia dg, Thuthu tt);
        void XoaPhieu(string maphieu);
        void SuaPhieu(PhieuMuon pm, Sach sa,DocGia dg,Thuthu tt);
        List<PhieuMuon> TimPhieu(PhieuMuon pm);
    }
}
