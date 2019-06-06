using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CtNguyenLieuDTO
    {
        private string maNl;
        private string dVt;
        private string tonKho;
        private string hSd;
        private string ghiChu;

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

        public string TonKho
        {
            get
            {
                return tonKho;
            }

            set
            {
                tonKho = value;
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

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }
    }
}
