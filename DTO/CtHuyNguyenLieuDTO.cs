using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CtHuyNguyenLieuDTO
    {
        private string maHuyNl;
        private string maNl;
        private string dVt;
        private string soLuong;
        private string hSd;
        private string lyDoHuy;

        public string MaHuyNl
        {
            get
            {
                return maHuyNl;
            }

            set
            {
                maHuyNl = value;
            }
        }

        public string MaNl
        {
            get
            {
                return maNl;
            }

            set
            {
                maNl = value;
            }
        }

        public string DVt
        {
            get
            {
                return dVt;
            }

            set
            {
                dVt = value;
            }
        }

        public string SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public string HSd
        {
            get
            {
                return hSd;
            }

            set
            {
                hSd = value;
            }
        }

        public string LyDoHuy
        {
            get
            {
                return lyDoHuy;
            }

            set
            {
                lyDoHuy = value;
            }
        }
    }
}
