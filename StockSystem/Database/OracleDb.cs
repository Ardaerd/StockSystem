using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;


namespace StockSystem.Database
{
    internal class OracleDb
    {
        private OracleConnection conn = new OracleConnection("Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)" +
                                                             "(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));" +
                                                             "Password= ArEr.2000;User ID= SYSTEM");

        // opening the connection
        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
                Console.WriteLine("Connected to Oracle" + conn.ServerVersion);
            }
            
        }

        // closing the connection
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Connection is closed...");
            }
        }

        // returning the connection
        public OracleConnection getConnection()
        {
            return conn;
        }

        // function to return table of data
        // parameters = the parameters of the query
        public DataTable getData(string query, OracleParameter[] param)
        {
            OracleCommand command = new OracleCommand(query,getConnection());

            if (param != null)
            {
                command.Parameters.AddRange(param);
            }

            DataTable table = new DataTable();

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // Function to set data and execute query
        public int setData(string query, OracleParameter[] param)
        {
            OracleCommand command = new OracleCommand(query, getConnection());

            if (param != null)
            {
                command.Parameters.AddRange(param);
            }

            openConnection();

            var affectedRows = command.ExecuteNonQuery();

            closeConnection();

            return affectedRows;
        }
    }
}
