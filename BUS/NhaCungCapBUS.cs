using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAL nhacc_dal = new NhaCungCapDAL();
        public DataTable NhaCc_Select()
        {
            return nhacc_dal.NhaCc_Select();
        }

        public DataTable NhaCc_SelectMa(NhaCungCapDTO nhacc)
        {
            return nhacc_dal.NhaCc_SelectMa(nhacc);
        }

        public DataTable NhaCc_Insert(NhaCungCapDTO nhacc)
        {
            return nhacc_dal.NhaCc_Insert(nhacc);
        }

        public DataTable NhaCc_Delete(NhaCungCapDTO nhacc)
        {
            return nhacc_dal.NhaCc_Delete(nhacc);
        }

        public DataTable NhaCc_Update(NhaCungCapDTO nhacc)
        {
            return nhacc_dal.NhaCc_Update(nhacc);
        }
    }
}
