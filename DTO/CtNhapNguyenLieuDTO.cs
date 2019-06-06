using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CtNhapNguyenLieuDTO
    {
        private string maNhapNl;
        private string maNl;
        private string soLuong;
        private string donViTinh;
        private string hSd;
        private string donGia;

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

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
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

        public string DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }
    }
}
