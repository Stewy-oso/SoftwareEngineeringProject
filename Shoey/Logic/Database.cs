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

        public void CreateNewCust(string name, string email, string password) //find how to add dates
        {
            using(OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO CUSTOMERS(CUSTOMERID, NAME, EMAIL, PASSWORD_HASH)
                                 VALUES(CUSTOMER_SEQ.NEXTVAL, :name, :email, :password)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":name", name);
                cmd.Parameters.Add(":email", email);
                cmd.Parameters.Add(":password", password);

                cmd.ExecuteNonQuery();
            }
        }

        public int CustIDFromDB(string email, string hashed)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT CUSTOMERID FROM CUSTOMERS WHERE EMAIL = :email AND PASSWORD_HASH = :password";

                OracleCommand cmd = new OracleCommand(query, conn);

                
                cmd.Parameters.Add(":email", email);
                cmd.Parameters.Add(":password", hashed);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    return -1;
                }
                else
                {
                    return Convert.ToInt32(result);
                }
            }
        }

        /*
         CREATE A LOGIN, MAYBE THROUGH EMAIL?
         */

        // had to make int to return a value, in this case to pass through sales 
        public int CreateOrder(int productID, int qty)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query1 = @"INSERT INTO ORDERS (ORDERID, PRODUCTID, QUANTITY)
                                 VALUES (ORDERS_SEQ.NEXTVAL, :p_id, :p_qty)";

                OracleCommand cmd = new OracleCommand(query1, conn);
                
                cmd.Parameters.Add(":p_id", productID);
                cmd.Parameters.Add(":p_qty", qty);

                cmd.ExecuteNonQuery();  

                string query2 = "SELECT ORDERS_SEQ.CURRVAL FROM DUAL";

                /* 
                 Title:  SQL Language Reference
                 Author: oracle.com
                 Date: November 2025
                 Website: https://docs.oracle.com/en/database/oracle//oracle-database/19/sqlrf/Sequence-Pseudocolumns.html
                 Code: ORDERS_SEQ.CURRVAL
                 */

                OracleCommand cmd1 = new OracleCommand(query2, conn);
                
                return Convert.ToInt32(cmd1.ExecuteScalar());
                
            }
        }

        public void CreateSale(int ProductID, int qty, int customerId, decimal total)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                int orderId = CreateOrder(ProductID, qty);

                string query = @"INSERT INTO SALES (SALEID, SALES_DATE, TOTAL, ORDERID, CUSTOMERID)
                                 VALUES (SALES_SEQ.NEXTVAL, SYSDATE, :total, :orderId, :customerId)";

                OracleCommand cmd = new OracleCommand(query, conn);
                
                cmd.Parameters.Add(":total", total);
                cmd.Parameters.Add(":orderId", orderId);
                cmd.Parameters.Add(":customerId", customerId);

                cmd.ExecuteNonQuery();
                
            }
        }

        public int FindSaleTotal()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT TOTAL FROM SALES";

                OracleCommand cmd = new OracleCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public String ListSales()
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM SALES";

                OracleCommand cmd = new OracleCommand(query, conn);

                return Convert.ToString(cmd.ExecuteScalar());
            }
        }
    }
}
