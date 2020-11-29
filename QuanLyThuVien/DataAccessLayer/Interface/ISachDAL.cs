using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.Entities;

namespace QuanLyThuVien.DataAccessLayer
{
    public interface ISachDAL
    {
        List<Sach> GetAllSach();
        void ThemSach(Sach sa);
        void Update(List<Sach> listsa);    
    }
}