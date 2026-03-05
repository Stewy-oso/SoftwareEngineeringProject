using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Shoey
{
    public class Database
    {
        
        string connectionString = ConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;

        //Remainder of class goes here
         /*

        Example of a connection to the database:

        OracleConnection conn = new OracleConnection (Database.connectionString);
        conn.Open(); // Open the connection
        conn.Close(); // Close the connection

         */

        public DataTable getSaleItems()
        {
            using (OracleConnection conn = new OracleConnection (connectionString)) 
            {
                string query = "SELECT * FROM PRODUCTS";

                OracleDataAdapter da = new OracleDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
