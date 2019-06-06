using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    
    public class Connect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TH2EAV2\SQLEXPRESS;Initial Catalog=QL_TRASUA1;Integrated Security=True");

        public void openConnect()
        {
            con.Open();
        }

        public void closeConnect()
        {
            con.Close();
        }
    }
}
