using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HuyNguyenLieuDTO
    {
        private string maHuyNl;
        private string tenDn;
        private string ngayHuy;

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

        public string NgayHuy
        {
            get
            {
                return ngayHuy;
            }

            set
            {
                ngayHuy = value;
            }
        }
    }
}
