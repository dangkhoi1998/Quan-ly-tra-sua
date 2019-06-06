using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class NhapNguyenLieuBUS
    {
        NhapNguyenLieuDAL nhapnl_dal = new NhapNguyenLieuDAL();
        public bool NhapNl_Insert(NhapNguyenLieuDTO nhapnl)
        {
            return nhapnl_dal.NhapNguyenLieu_Insert(nhapnl);
        }
    }
}
