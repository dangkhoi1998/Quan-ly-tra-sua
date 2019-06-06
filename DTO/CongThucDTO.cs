using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongThucDTO
    {
        private string maSp;
        private string maNl;
        private string tieuHao;
        private string dVt;

        public string MaSp
        {
            get
            {
                return maSp;
            }

            set
            {
                maSp = value;
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

        public string TieuHao
        {
            get
            {
                return tieuHao;
            }

            set
            {
                tieuHao = value;
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
    }
}
