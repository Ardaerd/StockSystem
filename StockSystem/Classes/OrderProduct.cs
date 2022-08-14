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
    internal class OrderProduct
    {
        private OracleDb db = new OracleDb();

        // Create a function to add product to the order in the orderProduct table
        public bool addOrder(string cname, int pid, int quantity, DateTime deliveryDate)
        {
            string query = "INSERT INTO orderProduct(cname,pid,quantity,deliveryDate) VALUES(:cname,:pid,:quantity,:deliveryDate)";

            OracleParameter[] param = new OracleParameter[4];

            param[0] = new OracleParameter("cname", OracleDbType.Varchar2);
            param[0].Value = cname;

            param[1] = new OracleParameter("pid", OracleDbType.Int32);
            param[1].Value = pid;

            param[2] = new OracleParameter("quantity", OracleDbType.Int32);
            param[2].Value = quantity;

            param[3] = new OracleParameter("deliveryDate", OracleDbType.Date);
            param[3].Value = deliveryDate;


            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create function to delete data from orderProduct table
        public bool deleteOrder(int opid)
        {
            string query = "DELETE FROM orderProduct WHERE opid = :opid";

            OracleParameter[] param = new OracleParameter[1];

            param[0] = new OracleParameter("opid", OracleDbType.Int32);
            param[0].Value = opid;


            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to get list of data from the table in the query
        public DataTable getList(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);

            return table;
        }
    }
}
