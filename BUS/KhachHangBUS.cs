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
    public class KhachHangBUS
    {
        KhachHangDAL khachhang_dal = new KhachHangDAL();
        public DataTable KhachhangSelect()
        {
            return khachhang_dal.KhachhangSelect();
        }

        public string KhachhangInsert(KhachHangDTO khachhang)
        {
            return khachhang_dal.KhachhangInsert(khachhang);
        }

        public int KhachhangUpdate(KhachHangDTO khachhang)
        {
            return khachhang_dal.KhachhangUpdate(khachhang);
        }

        public bool KhachhangDelete(KhachHangDTO khachhang)
        {
            return khachhang_dal.KhachhangDelete(khachhang);
        }

        public DataTable KhachhangSelectSdt(KhachHangDTO khachhang)
        {
            return khachhang_dal.KhachhangSelectSdt(khachhang);
        }
        public DataTable KhachhangChapnhan(KhachHangDTO khachhang)
        {
            return khachhang_dal.KhachhangChapnhan(khachhang);
        }
        public void KhachhangTanghang()
        {
            khachhang_dal.KhachhangTanghang();
        }
    }
}
