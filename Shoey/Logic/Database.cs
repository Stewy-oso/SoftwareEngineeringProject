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
                string query = "SELECT * FROM SHOES";

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

                string query = @"UPDATE SHOES 
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

                string query = "SELECT * FROM SHOES WHERE PRODUCTID = :id";

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

                string query = "DELETE FROM SHOES WHERE PRODUCTID = :id";

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

                string query = @"INSERT INTO SHOES (PRODUCTID, NAME, COLOUR, MANUFACTURER, QTY, PRICE)
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

        public void CreateNewCust(string name, string surname, string email, string password) //find how to add dates
        {
            using(OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO CUSTOMERS(CUSTOMERID, FORENAME, SURNAME, EMAIL, PASSWORD_HASH, STATUSID)
                                 VALUES(CUSTOMER_SEQ.NEXTVAL, :name, :surname, :email, :password, 1)";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":name", name);
                cmd.Parameters.Add(":name", surname);
                cmd.Parameters.Add(":email", email);
                cmd.Parameters.Add(":password", password);

                cmd.ExecuteNonQuery();
            }
        }

        public int Login(string email, string hashed)
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

        public void CreateSales_Items(int saleID, int productID, int qty)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query1 = @"
                    INSERT INTO SALES_ITEMS
                    (SALEITEMID, SALEID, PRODUCTID, QUANTITY)
                    VALUES
                    (SALES_ITEMS_SEQ.NEXTVAL, :saleID, :p_id, :p_qty)";

                OracleCommand cmd = new OracleCommand(query1, conn);
                
                cmd.Parameters.Add(":saleID", saleID);
                cmd.Parameters.Add(":p_id", productID);
                cmd.Parameters.Add(":p_qty", qty);

                cmd.ExecuteNonQuery();  

                //string query2 = "SELECT ORDERS_SEQ.CURRVAL FROM DUAL";

                /* 
                 Title:  SQL Language Reference
                 Author: oracle.com
                 Date: November 2025
                 Website: https://docs.oracle.com/en/database/oracle//oracle-database/19/sqlrf/Sequence-Pseudocolumns.html
                 Code: ORDERS_SEQ.CURRVAL
                 */

                //OracleCommand cmd1 = new OracleCommand(query2, conn);
                
                //return Convert.ToInt32(cmd1.ExecuteScalar());
                
            }
        }

        public int CreateSale(int customerID, decimal total)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO SALES (SALEID, SALES_DATE, TOTAL, CUSTOMERID)
                                 VALUES (SALES_SEQ.NEXTVAL, SYSDATE, :total, :customerId)";

                OracleCommand cmd = new OracleCommand(query, conn);
                
                cmd.Parameters.Add(":total", total);
                cmd.Parameters.Add(":customerId", customerID);

                cmd.ExecuteNonQuery();

                string query2 = "SELECT SALES_SEQ.CURRVAL FROM DUAL";

                /* 
                 Title:  SQL Language Reference
                 Author: oracle.com
                 Date: November 2025
                 Website: https://docs.oracle.com/en/database/oracle//oracle-database/19/sqlrf/Sequence-Pseudocolumns.html
                 Code: ORDERS_SEQ.CURRVAL
                 */

                OracleCommand cmd2 = new OracleCommand(query2, conn);

                return Convert.ToInt32(cmd2.ExecuteScalar());

            }
        }

        public string GetCustomerName(int custID)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Forename, Surname FROM Customers WHERE CustomerID = :custID";

                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(":custID", custID);

                object result = cmd.ExecuteScalar();

                return result.ToString();
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
