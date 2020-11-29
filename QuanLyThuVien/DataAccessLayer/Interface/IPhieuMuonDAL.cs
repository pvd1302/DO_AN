using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    public interface IPhieuMuonDAL
    {
        List<PhieuMuon> GetAllPhieuMuon();
        void ThemPhieu(PhieuMuon pm, Sach sa, DocGia dg, Thuthu tt);
        void Update(List<PhieuMuon> listpm, List<Sach> listsa, List<DocGia> listdg, List<Thuthu> list);
    }
}