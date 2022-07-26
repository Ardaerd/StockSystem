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
    internal class StockCompany
    {
        private OracleDb db = new OracleDb();

        // Create a function to add company to the stock in the stockCompany table
        public bool addStockCompany(int cid, int tip, string status, DateTime irsaliyeDate, int irsaliyeNo)
        {
            string query = "INSERT INTO stockCompany(cid,tip,status,irsaliyeDate,irsaliyeNo) VALUES(:cid,:tip,:status,:irsaliyeDate,:irsaliyeNo)";

            OracleParameter[] param = new OracleParameter[5];

            param[0] = new OracleParameter("cid", OracleDbType.Int32);
            param[0].Value = cid;

            param[1] = new OracleParameter("tip", OracleDbType.Int32);
            param[1].Value = tip;

            param[2] = new OracleParameter("status", OracleDbType.Varchar2);
            param[2].Value = status;

            param[3] = new OracleParameter("irsaliyeDate", OracleDbType.Date);
            param[3].Value = irsaliyeDate;

            param[4] = new OracleParameter("irsaliyeNo", OracleDbType.Int32);
            param[4].Value = irsaliyeNo;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to edit company in the stock in the stockCompany table
        public bool editStockProduct(int sid, int cid, int tip, string status, DateTime irsaliyeDate, int irsaliyeNo)
        {
            string query = "UPDATE stockCompany SET cid = :cid, tip = :tip, status = :status, irsaliyeDate = :irsaliyeDate, irsaliyeNo = :irsaliyeNo WHERE sid = :sid";

            OracleParameter[] param = new OracleParameter[6];

            param[0] = new OracleParameter("cid", OracleDbType.Int32);
            param[0].Value = cid;

            param[1] = new OracleParameter("tip", OracleDbType.Int32);
            param[1].Value = tip;

            param[2] = new OracleParameter("status", OracleDbType.Varchar2);
            param[2].Value = status;

            param[3] = new OracleParameter("irsaliyeDate", OracleDbType.Date);
            param[3].Value = irsaliyeDate;

            param[4] = new OracleParameter("irsaliyeNo", OracleDbType.Int32);
            param[4].Value = irsaliyeNo;

            param[5] = new OracleParameter("sid", OracleDbType.Int32);
            param[5].Value = sid;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create a function to delete company in the stockProduct table
        public bool deleteStockProduct(int sid)
        {
            string query =
                "DELETE FROM stockCompany WHERE sid = :sid";

            OracleParameter[] param = new OracleParameter[1];

            param[0] = new OracleParameter("sid", OracleDbType.Int32);
            param[0].Value = sid;

            if (db.setData(query, param) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Create function to return a table of stockCompany
        public DataTable stockCompanyList(string query)
        {
            DataTable table = new DataTable();
            table = db.getData(query, null);

            return table;
        }
    }
}
