using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using StockSystem.Database;

namespace StockSystem.Classes
{
    internal class ProductInfo
    {
        private OracleDb db = new OracleDb();

        // Create a function to add product to the productInfo table
        public bool addProductInfo(string productName, string barcode, int sim, string pic, double price)
        {
            string query =
                "INSERT INTO productInfo(pname,barcode,sim,pic,price) VALUES(:name,:barcode,:sim,:pic,:price)";

            OracleParameter[] param = new OracleParameter[5];

            param[0] = new OracleParameter("name", OracleDbType.Varchar2);
            param[0].Value = productName;

            param[1] = new OracleParameter("barcode", OracleDbType.Varchar2);
            param[1].Value = barcode;

            param[2] = new OracleParameter("sim", OracleDbType.Int32);
            param[2].Value = sim;

            param[3] = new OracleParameter("pic", OracleDbType.Varchar2);
            param[3].Value = pic;

            param[4] = new OracleParameter("price", OracleDbType.Double);
            param[4].Value = price;


            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to edit product in the productInfo table
        public bool editProductInfo(int id, string productName, string barcode, int sim, string pic, double price)
        {
            string query =
                "UPDATE productInfo SET pname = :name, barcode = :barcode, sim = :sim, pic = :pic, price = :price WHERE pid = :id";

            OracleParameter[] param = new OracleParameter[6];

            param[0] = new OracleParameter("name", OracleDbType.Varchar2);
            param[0].Value = productName;

            param[1] = new OracleParameter("barcode", OracleDbType.Varchar2);
            param[1].Value = barcode;

            param[2] = new OracleParameter("sim", OracleDbType.Int32);
            param[2].Value = sim;

            param[3] = new OracleParameter("pic", OracleDbType.Varchar2);
            param[3].Value = pic;

            param[4] = new OracleParameter("price", OracleDbType.Double);
            param[4].Value = price;

            param[5] = new OracleParameter("id", OracleDbType.Int32);
            param[5].Value = id;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to delete product in the productInfo table
        public bool deleteProductInfo(int id)
        {
            string query =
                "DELETE FROM productInfo WHERE pid = :id";

            OracleParameter[] param = new OracleParameter[1];

            param[0] = new OracleParameter("id", OracleDbType.Int32);
            param[0].Value = id;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create function to return a table of productInfo
        public DataTable productInfoList(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);

            return table;
        }
    }
}
