using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BUS
{
    public class CtHuyNguyenLieuBUS
    {
        CtHuyNguyenLieuDAL cthuynl_dal = new CtHuyNguyenLieuDAL();
        public bool CtHuyNl_Insert(CtHuyNguyenLieuDTO cthuynl)
        {
            return cthuynl_dal.CtHuyNl_Insert(cthuynl);
        }

        public bool CtHuyNl_DeleteNl(CtNguyenLieuDTO ctnl)
        {
            return cthuynl_dal.CtHuyNl_DeleteNl(ctnl);
        }
    }
}
