using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBconnect
    {
        protected SqlConnection _con = new SqlConnection(@"Data Source=DESKTOP-10EUU23\SQLEXPRESS;Initial Catalog=QLNH_DA1_10121268_DVP;Integrated Security=True");
    }
    
}
