using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

        public void UpdateStockItems(int productID, decimal price, int qty, string colour)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE PRODUCTS 
                               SET PRICE = :price,
                                    QTY = QTY + :qty, 
                                    COLOUR = :colour 
                               WHERE PRODUCTID = :id";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":price", price);
                cmd.Parameters.Add(":qty", qty);
                //cmd.Parameters.Add(":desc", description); I removed description entirely, too many issues with it
                cmd.Parameters.Add(":colour", colour);
                cmd.Parameters.Add(":id", productID);

                cmd.ExecuteNonQuery();

            }
        }

        public DataTable FindSelectedInfo(int productID)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM PRODUCTS WHERE PRODUCTID = :id";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":id", productID);
                
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public void DeleteProduct(int productID)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM PRODUCTS WHERE PRODUCTID = :id";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":id", productID);

                cmd.ExecuteNonQuery();
            }
        }

        public void AddNewStock(string name, int qty, decimal price, string colour, string manufacturer)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO PRODUCTS (PRODUCTID, NAME, COLOUR, MANUFACTURER, QTY, PRICE)
                                VALUES (PRODUCT_SEQ.NEXTVAL, :name, :colour, :manufacturer, :qty, :price)";

                /* 
                 Title:  How to Get Nextval from Parameterized Sequence in Spring JPA: Fixing Hibernate Positional Param Exception
                 Author: W3Tutorials.net
                 Date: Jan 16, 2026
                 Website: https://www.w3tutorials.net/blog/query-to-get-nextval-from-sequence-with-spring-jpa/
                 Code: PRODUCT_SEQ  .NEXTVAL
                 */

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":name", name);
                cmd.Parameters.Add(":colour", colour);
                cmd.Parameters.Add(":manufacturer", manufacturer);
                cmd.Parameters.Add(":qty", qty);
                cmd.Parameters.Add(":price", price);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
