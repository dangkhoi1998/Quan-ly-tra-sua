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
    public class NguyenLieuBUS
    {
        private NguyenLieuDAL nguyenlieu_dal = new NguyenLieuDAL();
        public DataTable NguyenLieu_SelectAll()
        {
            return nguyenlieu_dal.NguyenLieu_SelectAll();
        }

        public DataTable NguyenLieu_Select()
        {
            return nguyenlieu_dal.NguyenLieu_Select();
        }

        public DataTable NguyenLieu_SelectAllMa(NguyenLieuDTO nguyenlieu)
        {
            return nguyenlieu_dal.NguyenLieu_SelectAllMa(nguyenlieu);
        }

        public DataTable NguyenLieu_Insert(NguyenLieuDTO nguyenlieu)
        {
            return nguyenlieu_dal.NguyenLieu_Insert(nguyenlieu);
        }

        public DataTable NguyenLieu_Delete(NguyenLieuDTO nguyenlieu)
        {
            return nguyenlieu_dal.NguyenLieu_Delete(nguyenlieu);
        }
    }
}
