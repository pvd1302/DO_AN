using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Entities
{
    public class Sach
    {
        #region cac thanh phan du lieu

        private string masach;
        private string tensach;
        private string loaisach;
        private string NXB;
        private int soluong;

        #endregion

        #region cac thuoc tinh

        public string MaSach
        {
            get { return masach; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    masach = value;
            }
        }
        public string TenSach
        {
            get { return tensach; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tensach = value;
            }
        }
        public string LoaiSach
        {
            get { return loaisach; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    loaisach = value;
            }
        }
        public string NhaXuatban
        {
            get { return NXB; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    NXB = value;
            }
        }
        public int SoLuong
        {
            get { return soluong; }
            set
            {
                if (value > 0)
                    soluong = value;
            }
        }

        #endregion

        #region cac phuong thuc

        public Sach() { }
        public Sach(Sach sa)
        {
            this.masach = sa.MaSach;
            this.tensach = sa.TenSach;
            this.loaisach = sa.LoaiSach;
            this.NXB = sa.NhaXuatban;
            this.soluong = sa.SoLuong;
        }
        public Sach(string masach, string tensach, string loaisach, string NXB, int soluong)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.loaisach = loaisach;
            this.NXB = NXB;
            this.soluong = soluong;
        }

        #endregion
    }
}