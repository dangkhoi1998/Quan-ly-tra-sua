using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string tenDn;
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

        private string matKhau;
        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        private string chuTk;
        public string ChuTk
        {
            get
            {
                return chuTk;
            }

            set
            {
                chuTk = value;
            }
        }

        private string quyen;
        public string Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }
    }
}
