using Oracle.ManagedDataAccess.Client;
using StockSystem.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Classes
{
    internal class ProductPrice
    {
        private OracleDb db = new OracleDb();

        // Create a function to add product to the productInfo table
        public bool addProductInfo(int pid, DateTime date, double price)
        {
            string query =
                "INSERT INTO productPrice(pid,priceValidityDate,price) VALUES(:pid,:priceValidityDate,:price)";

            OracleParameter[] param = new OracleParameter[3];

            param[0] = new OracleParameter("pid", OracleDbType.Int32);
            param[0].Value = pid;

            param[1] = new OracleParameter("priceValidityDate", OracleDbType.Date);
            param[1].Value = date;

            param[2] = new OracleParameter("price", OracleDbType.Double);
            param[2].Value = price;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editProductPrice(int pid, DateTime date, double price)
        {
            string query =
                "UPDATE productPrice SET price = :price WHERE pid = :pid AND priceValidityDate = :priceValidityDate";

            OracleParameter[] param = new OracleParameter[3];

            param[0] = new OracleParameter("price", OracleDbType.Double);
            param[0].Value = price;

            param[1] = new OracleParameter("pid", OracleDbType.Int32);
            param[1].Value = pid;

            param[2] = new OracleParameter("date", OracleDbType.Date);
            param[2].Value = date;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to delete product in the productPrice table
        public bool deleteProductPrice(int id,DateTime date)
        {
            string query =
                "DELETE FROM productPrice WHERE pid = :pid AND priceValidityDate = :priceValidityDate";

            OracleParameter[] param = new OracleParameter[2];

            param[0] = new OracleParameter("pid", OracleDbType.Int32);
            param[0].Value = id;

            param[1] = new OracleParameter("priceValidityDate", OracleDbType.Date);
            param[1].Value = date;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create function to return a table of productPrice
        public DataTable productPriceList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM productPrice", null);

            return table;
        }
    }
}
