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
    internal class Company
    {
        private OracleDb db = new OracleDb();

        // Create a function to add company to the company table
        public bool addCompany(string companyName)
        {
            string query = "INSERT INTO company(cname) VALUES(:cname)";

            OracleParameter[] param = new OracleParameter[1];

            param[0] = new OracleParameter("cname", OracleDbType.Varchar2);
            param[0].Value = companyName;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to edit company in the company table
        public bool editCompany(int id,string cname)
        {
            string query =
                "UPDATE company SET cname = :cname WHERE cid = :cid";

            OracleParameter[] param = new OracleParameter[2];

            param[0] = new OracleParameter("cname", OracleDbType.Varchar2);
            param[0].Value = cname;

            param[1] = new OracleParameter("cid", OracleDbType.Int32);
            param[1].Value = id;

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
        public bool deleteCompany(int cid)
        {
            string query =
                "DELETE FROM company WHERE cid = :cid";

            OracleParameter[] param = new OracleParameter[1];

            param[0] = new OracleParameter("cid", OracleDbType.Int32);
            param[0].Value = cid;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create function to return a table of company
        public DataTable companyList(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);

            return table;
        }
    }
}
