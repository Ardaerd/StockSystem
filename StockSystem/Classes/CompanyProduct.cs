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
    internal class CompanyProduct
    {
        private OracleDb db = new OracleDb();

        // Create a function to add company product pair to the company product table
        public bool addComapnyProduct(int pid, int cid)
        {
            string query = "INSERT INTO companyProduct(pid,cid) VALUES(:pid,:cid)";

            OracleParameter[] param = new OracleParameter[2];

            param[0] = new OracleParameter("pid",OracleDbType.Int32);
            param[0].Value = pid;

            param[1] = new OracleParameter("cid", OracleDbType.Int32);
            param[1].Value = cid;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to delete company in the company table
        public bool deleteCompany(int pid,int cid)
        {
            string query =
                "DELETE FROM companyProduct WHERE pid = :pid AND cid = :cid";

            OracleParameter[] param = new OracleParameter[2];

            param[0] = new OracleParameter("pid", OracleDbType.Int32);
            param[0].Value = pid;

            param[1] = new OracleParameter("cid", OracleDbType.Int32);
            param[1].Value = cid;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create function to return a table of companyProduct
        public DataTable companyProductList(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);

            return table;
        }
    }
}
