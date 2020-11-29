using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Entities
{
    public class Thuthu
    {
        #region cac thanh phan du lieu

        private string matt;
        private string tentt;
        private string ngaysinhtt;
        private string gioitinhtt;
        private string diachitt;
        private int sdttt;
        private int cmndtt;

        #endregion

        #region cac thuoc tinh

        public string MaThuThu
        {
            get { return matt; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    matt = value;
            }
        }
        public string TenThuThu
        {
            get { return tentt; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tentt = value;
            }
        }
        public string NgaySinhThuThu
        {
            get { return ngaysinhtt; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ngaysinhtt = value;
            }
        }
        public string GioiTinhThuThu
        {
            get { return gioitinhtt; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    gioitinhtt = value;
            }
        }
        public string DiaChithuthu
        {
            get { return diachitt; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    diachitt = value;
            }
        }
        public int SDTThuThu
        {
            get { return sdttt; }
            set
            {
                if (value == 10)
                    sdttt = value;
            }
        }
        public int CMNDthuThu
        {
            get { return cmndtt; }
            set
            {
                if (value == 9 | value == 10)
                    cmndtt = value;
            }
        }

        #endregion

        #region cac phuong thuc

        public Thuthu() { }

        public Thuthu(Thuthu tt)
        {
            this.matt = tt.matt;
            this.tentt = tt.tentt;
            this.ngaysinhtt = tt.ngaysinhtt;
            this.gioitinhtt = tt.gioitinhtt;
            this.diachitt = tt.diachitt;
            this.sdttt = tt.sdttt;
            this.cmndtt = tt.cmndtt;
        }
        public Thuthu(string matt, string tentt, string ngaysinhtt, string gioitinhtt, string diachitt, int sdttt, int cmndtt)
        {
            this.matt = matt;
            this.tentt = tentt;
            this.ngaysinhtt = ngaysinhtt;
            this.gioitinhtt = gioitinhtt;
            this.diachitt = diachitt;
            this.sdttt = sdttt;
            this.cmndtt = cmndtt;
        }

        #endregion
    }
}
        
    