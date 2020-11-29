using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Entities
{
    public class PhieuMuon
    {
        #region cac thanh phan du lieu

        private string maphieu;
        private int soluongmuon;
        private string ngaymuon;
        private int tgmuon;

        #endregion

        #region Cac thuoc tinh

        public string MaPhieuMuon
        {
            get { return maphieu; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    maphieu = value;
            }
        }
        public int SoLuongMuon
        {
            get { return soluongmuon; }
            set
            {
                if (value > 0)
                    soluongmuon = value;
            }
        }
        public string NgayMuon
        {
            get { return ngaymuon; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ngaymuon = value;
            }
        }
        public int ThoiGianMuon
        {
            get { return tgmuon; }
            set
            {
                if (value > 0)
                    tgmuon = value;
            }
        }

        #endregion

        #region Cac phuong thuc

        public PhieuMuon() { }
        public PhieuMuon(PhieuMuon pm)
        {
            this.maphieu = pm.maphieu;
            this.soluongmuon = pm.soluongmuon;
            this.ngaymuon = pm.ngaymuon;
            this.tgmuon = pm.tgmuon;
        }
        public PhieuMuon(string maphieu, int soluongmuon, string ngaymuon, int tgmuon)
        {
            this.maphieu = maphieu;
            this.soluongmuon = soluongmuon;
            this.ngaymuon = ngaymuon;
            this.tgmuon = tgmuon;
        }

        #endregion
    }
}
