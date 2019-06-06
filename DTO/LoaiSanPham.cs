using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        private string maLoaiSp;
        public string MaLoaiSp
        {
            get { return maLoaiSp;  }
            set { maLoaiSp = value;  }
        }

        private string tenLoaiSp;
        public string TenLoaiSp
        {
            get { return tenLoaiSp; }
            set { tenLoaiSp = value; }
        }
    }
}
