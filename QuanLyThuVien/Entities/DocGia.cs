using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Entities
{
    public class DocGia
    {
        #region cac thanh phan du lieu

        private string madg;
        private string tendg;
        private string ngaysinhdg;
        private string gioitinhdg;
        private string diachidg;
        private int sdtdg;
        private int cmnddg;

        #endregion

        #region cac thuoc tinh

        public string MaDocGia
        {
            get { return madg; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    madg = value;
            }
        }
        public string TenDocgia
        {
            get { return tendg; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    tendg = value;
            }
        }
        public string NgaySinhDocGia
        {
            get { return ngaysinhdg; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ngaysinhdg = value;
            }
        }
        public string GioiTinhDocGia
        {
            get { return gioitinhdg; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    gioitinhdg = value;
            }
        }
        public string DiaChiDocGia
        {
            get { return diachidg; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    diachidg = value;
            }
        }
        public int SDTDocGia
        {
            get { return sdtdg; }
            set
            {
                if (value == 10)
                    sdtdg = value;
            }
        }
        public int CMNDDocGia
        {
            get { return cmnddg; }
            set
            {
                if (value == 9 | value ==10)
                    cmnddg = value;
            }
        }

        #endregion

        #region cac phuong thuc

        public DocGia() { }
        public DocGia(DocGia dg)
        {
            this.madg = dg.madg;
            this.tendg = dg.tendg;
            this.ngaysinhdg = dg.ngaysinhdg;
            this.gioitinhdg = dg.gioitinhdg;
            this.diachidg = dg.diachidg;
            this.sdtdg = dg.sdtdg;
            this.cmnddg = dg.cmnddg;
        }
        public DocGia(string madg, string tendg, string ngaysinhdg, string gioitinhdg, string diachidg, int sdtdg, int cmnddg)
        {
            this.madg = madg;
            this.tendg = tendg;
            this.ngaysinhdg = ngaysinhdg;
            this.gioitinhdg = gioitinhdg;
            this.diachidg = diachidg;
            this.sdtdg = sdtdg;
            this.cmnddg = cmnddg;
        }

        #endregion
    }
}