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

        public void UpdateStockItems(int productID, decimal price, int qty, string description, string colour)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE PRODUCTS 
                               SET PRICE = PRICE + :price,
                                    QTY = QTY + :qty, 
                                    DESCRIPTION = DESCRIPTION + :desc, 
                                    COLOUR = COLOUR + :colour 
                               WHERE PRODUCTID = :id";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":price", price);
                cmd.Parameters.Add(":qty", qty);
                cmd.Parameters.Add(":desc", description);
                cmd.Parameters.Add(":colour", colour);
                cmd.Parameters.Add(":id", productID);

                cmd.ExecuteNonQuery();

            }
        }

        public DataTable FindSelectedInfo(/*int productID, decimal price, int qty, string description, string colour*/)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * WHERE PRODUCTID = :id";

                OracleDataAdapter da = new OracleDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
