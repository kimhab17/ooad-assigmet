using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace saleAndBillingSystem
{
    public class Database
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=. \SQLEXPRESS;Initial Catalog=SalesBillingDB;Integrated Security=True");
            return conn;
        }
    }
}
