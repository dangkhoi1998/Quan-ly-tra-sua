﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class CtNguyenLieuBUS
    {
        CtNguyenLieuDAL ctnguyenlieu_dal = new CtNguyenLieuDAL();
        public DataTable CtNguyenLieu_Dvt()
        {
            return ctnguyenlieu_dal.CtNguyenLieu_Dvt();
        }
    }
}
