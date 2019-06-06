using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class HuyNguyenLieuBUS
    {
        HuyNguyenLieuDAL huynl_dal = new HuyNguyenLieuDAL();
        public bool HuyNl_Insert(HuyNguyenLieuDTO huynl)
        {
            return huynl_dal.HuyNguyenLieu_Insert(huynl);
        }
    }
}
