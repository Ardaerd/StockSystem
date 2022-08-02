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
    internal class StockTracking
    {
        private OracleDb db = new OracleDb();
        // Create function to return a view of stockTracking
        public DataTable stockTrackingList(string starDate, string endDate, String cname)
        {
            string query;
            OracleParameter[] param;
            DataTable table = new DataTable();

            if (cname.Trim().Equals(""))
            {
                query = "SELECT * FROM stockCompany " +
                        "WHERE stockEntryDate BETWEEN TO_DATE('"+ starDate + "','DD/MM/YYYY') AND TO_DATE('" + endDate + "','DD/MM/YYYY')";


                table = db.getData(query, null);

                /*query = "SELECT * FROM stockTracking_view " +
                        "WHERE stockEntryDate BETWEEN TO_DATE(:startDate,'DD/MM/YYYY') AND SYSDATE";

                param = new OracleParameter[1];

                param[0] = new OracleParameter("startDate", OracleDbType.Date);
                param[0].Value = starDate.Date;*/



            }

            else
            {
                query = "SELECT * FROM stockTracking_view " +
                        "WHERE stockEntryDate BETWEEN TO_DATE('" + starDate + "','DD/MM/YYYY') AND TO_DATE('" + endDate + "','DD/MM/YYYY') AND cname LIKE '% "+ cname + "%'";

                table = db.getData(query, null);

                /*query = "SELECT * FROM stockTracking_view " +
                        "WHERE stockEntryDate BETWEEN TO_DATE(:startDate,'DD/MM/YYYY') AND TO_DATE(:endDate,'DD/MM/YYYY') AND cname LIKE '%:cname%'";

                param = new OracleParameter[3];

                param[0] = new OracleParameter("startDate", OracleDbType.Date);
                param[0].Value = starDate;

                param[1] = new OracleParameter("endDate", OracleDbType.Date);
                param[1].Value = endDate;

                param[2] = new OracleParameter("cname", OracleDbType.Varchar2);
                param[2].Value = cname;*/

            }

            return table;
        }
    }
}
