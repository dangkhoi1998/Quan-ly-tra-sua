using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class NhaCungCapDTO
    {
        private string maNhaCc;
        private string tenNhaCc;
        private string diaChi;
        private string sDt;

        public string MaNhaCc
        {
            get
            {
                return maNhaCc;
            }

            set
            {
                maNhaCc = value;
            }
        }

        public string TenNhaCc
        {
            get
            {
                return tenNhaCc;
            }

            set
            {
                tenNhaCc = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SDt
        {
            get
            {
                return sDt;
            }

            set
            {
                sDt = value;
            }
        }
    }
}
