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
    public class CtNhapNguyenLieuBUS
    {
        public CtNhapNguyenLieuDAL ctnhapnl_dal = new CtNhapNguyenLieuDAL();
        public bool CtNhapNl_Insert(CtNhapNguyenLieuDTO ctnhapnl)
        {
            return ctnhapnl_dal.CtNhapNl_Insert(ctnhapnl);
        }
        public DataTable CtNhapNl_InHd()
        {
            return ctnhapnl_dal.CtNhapNl_InHd();
        }

        public bool CtNhapNl_InsertNl(CtNguyenLieuDTO ctnl)
        {
            return ctnhapnl_dal.CtNhapNl_InsertNl(ctnl);
        }
    }
}
