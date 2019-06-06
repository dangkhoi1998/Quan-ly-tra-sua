using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapNguyenLieuDTO
    {
        private string maNhapNl;
        private string maNcc;
        private string tenDn;
        private string ngayNhap;
        private string tongTien;

        public string MaNhapNl
        {
            get
            {
                return maNhapNl;
            }

            set
            {
                maNhapNl = value;
            }
        }

        public string MaNcc
        {
            get
            {
                return maNcc;
            }

            set
            {
                maNcc = value;
            }
        }

        public string TenDn
        {
            get
            {
                return tenDn;
            }

            set
            {
                tenDn = value;
            }
        }

        public string NgayNhap
        {
            get
            {
                return ngayNhap;
            }

            set
            {
                ngayNhap = value;
            }
        }

        public string TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }
    }
}
