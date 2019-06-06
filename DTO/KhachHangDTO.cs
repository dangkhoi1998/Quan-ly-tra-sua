using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string maKh;

        private string tenKh;


        private string ngaySinh;


        private string diaChi;


        private string sDt;


        private string loaiKh;


        private string ngayLap;


        private string ghiChu;


        public string MaKh
        {
            get
            {
                return maKh;
            }

            set
            {
                maKh = value;
            }
        }

        public string TenKh
        {
            get
            {
                return tenKh;
            }

            set
            {
                tenKh = value;
            }
        }

        public string NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
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

        public string LoaiKh
        {
            get
            {
                return loaiKh;
            }

            set
            {
                loaiKh = value;
            }
        }

        public string NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
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