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
    internal class SoldProduct
    {
        private OracleDb db = new OracleDb();

        // Create a function to add product to the SoldProduct table
        public bool addSoldProduct(double price, int quantity, string barcode, int cashRegister_No, int document_No, DateTime irsaliyeDate)
        {
            string query = "INSERT INTO soldProduct(price,quantity,barcode,cashRegister_No,document_No,irsaliyeDate) VALUES(:price,:quantity,:barcode,:cashRegister_No,:document_No,:irsaliyeDate)";

            OracleParameter[] param = new OracleParameter[6];

            param[0] = new OracleParameter("price", OracleDbType.Double);
            param[0].Value = price;

            param[1] = new OracleParameter("quantity", OracleDbType.Int32);
            param[1].Value = quantity;

            param[2] = new OracleParameter("barcode", OracleDbType.Varchar2);
            param[2].Value = barcode;

            param[3] = new OracleParameter("cashRegister_No", OracleDbType.Int32);
            param[3].Value = cashRegister_No;

            param[4] = new OracleParameter("document_No", OracleDbType.Int32);
            param[4].Value = document_No;

            param[5] = new OracleParameter("irsaliyeDate", OracleDbType.Date);
            param[5].Value = irsaliyeDate;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to delete all of the data from the soldProduct table when service is started
        public bool deleteSoldProduct()
        {
            try
            {
                string query = "DELETE FROM soldProduct";

                db.setData(query, null);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        // Create function to get data from soldProduct table
        public DataTable getSoldProductsList(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);

            return table;
        }
    }
}
