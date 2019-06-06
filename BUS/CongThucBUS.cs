using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class CongThucBUS
    {
        private CongThucDAL congthuc_dal = new CongThucDAL();
        public DataTable CongThuc_SelectAll()
        {
            return congthuc_dal.CongThuc_SelectAll();
        }
        public DataTable CongThuc_SelectAllMaSp(CongThucDTO congthuc)
        {
            return congthuc_dal.CongThuc_SelectAllMaSp(congthuc);
        }
        public DataTable CongThuc_TenSpKoCt()
        {
            return congthuc_dal.CongThuc_TenSpKoCt();
        }
        public DataTable CongThuc_Insert(CongThucDTO congthuc)
        {
            return congthuc_dal.CongThuc_Insert(congthuc);
        }
        public DataTable CongThuc_Update(CongThucDTO congthuc)
        {
            return congthuc_dal.CongThuc_Update(congthuc);
        }
        public DataTable CongThuc_Delete(CongThucDTO congthuc)
        {
            return congthuc_dal.CongThuc_Delete(congthuc);
        }
        public DataTable Congthuc_KtLuong(CongThucDTO congthuc, string soluong)
        {
            DataTable dt = congthuc_dal.CongThuc_KtLuongSp(congthuc);
            if(dt.Rows[0][1].ToString() == "khong")
            {
                return dt;
            }
            else
            {
                DataTable dt2 = new DataTable();
                for(int i =0; i < dt.Rows.Count ; i++)
                {
                    CongThucDTO congthuc2 = new CongThucDTO();
                    congthuc2.MaSp = congthuc.MaSp;
                    congthuc2.MaNl = dt.Rows[i][0].ToString();
                    congthuc2.TieuHao = dt.Rows[i][1].ToString();
                    congthuc2.DVt = dt.Rows[i][2].ToString(); 
                    dt2 = congthuc_dal.CongThuc_KtLuongNl(congthuc2, soluong);
                    if(dt2 != null)
                    {
                        break;
                    }
                }
                return dt2;
            }
        }
        public bool CongThuc_ThucThi(CongThucDTO congthuc, string soluong)
        {
            DataTable dt = congthuc_dal.CongThuc_KtLuongSp(congthuc);
            if (dt.Rows[0][1].ToString() == "khong")
            {
                return false;
            }
            else
            {
                bool thucthi = new bool();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CongThucDTO congthuc2 = new CongThucDTO();
                    congthuc2.MaNl = dt.Rows[i][0].ToString();
                    congthuc2.TieuHao = dt.Rows[i][1].ToString();
                    congthuc2.DVt = dt.Rows[i][2].ToString();
                    thucthi = congthuc_dal.CongThuc_ThucThi(congthuc2, soluong);
                    if(thucthi == false)
                    {
                        break;
                    }
                }
                return thucthi;
            }
        }
    }
}
