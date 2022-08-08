using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using StockSystem.Database;

namespace StockSystem.Classes
{
    internal class StockProduct
    {
        private OracleDb db = new OracleDb();

        // Create a function to add product to the stock in the stockProduct table
        public bool addStockProduct(int sid,int pid,int quantity,double price,double total)
        {
            string query = "INSERT INTO stockProduct(sid,pid,quantity,price,total) VALUES(:sid,:pid,:quantity,:price,:total)";

            OracleParameter[] param = new OracleParameter[5];

            param[0] = new OracleParameter("sid", OracleDbType.Int32);
            param[0].Value = sid;

            param[1] = new OracleParameter("pid", OracleDbType.Int32);
            param[1].Value = pid;

            param[2] = new OracleParameter("quantity", OracleDbType.Int32);
            param[2].Value = quantity;

            param[3] = new OracleParameter("price", OracleDbType.Double);
            param[3].Value = price;

            param[4] = new OracleParameter("total", OracleDbType.Double);
            param[4].Value = total;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to edit product in the stock in the stockProduct table
        public bool editStockProduct(int sid,int pid, int quantity,double total)
        {
            string query = "UPDATE stockProduct SET quantity = :quantity, total = :total WHERE sid = :sid AND pid = :pid";

            OracleParameter[] param = new OracleParameter[4];

            param[0] = new OracleParameter("quantity", OracleDbType.Int32);
            param[0].Value = quantity;

            param[1] = new OracleParameter("total", OracleDbType.Double);
            param[1].Value = total;

            param[2] = new OracleParameter("sid", OracleDbType.Int32);
            param[2].Value = sid;

            param[3] = new OracleParameter("pid", OracleDbType.Int32);
            param[3].Value = pid;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to delete product in the stockProduct table
        public bool deleteStockProduct(int sid,int pid)
        {
            string query =
                "DELETE FROM stockProduct WHERE sid = :sid AND pid = :pid";

            OracleParameter[] param = new OracleParameter[2];

            param[0] = new OracleParameter("sid", OracleDbType.Int32);
            param[0].Value = sid;

            param[1] = new OracleParameter("pid", OracleDbType.Int32);
            param[1].Value = pid;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create function to return a table of stockProduct
        public DataTable stockProductList(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);

            return table;
        }

        // Create function to return a table of stockProduct
        public DataTable stockProductListWithSid(string query, int sid)
        {

            OracleParameter[] param = new OracleParameter[1];

            param[0] = new OracleParameter("sid", OracleDbType.Int32);
            param[0].Value = sid;

            DataTable table = new DataTable();
            table = db.getData(query, param);

            return table;
        }
    }
}
