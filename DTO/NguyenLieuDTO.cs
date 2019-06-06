using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieuDTO
    {
        private string maNl;
        private string tenNl;

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

        public string TenNl
        {
            get
            {
                return tenNl;
            }

            set
            {
                tenNl = value;
            }
        }
    }
}
