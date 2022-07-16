using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EjemplosPatrones.Singleton
{
    public class HelperSQLServer
    {
        private static HelperSQLServer HSQLServer { get; set; }
        private static SqlConnection oConnection { get; set; }

        private HelperSQLServer() {

        }

        public static HelperSQLServer getInstance() {
            if(HSQLServer == null) {
                HSQLServer = new HelperSQLServer();
            }
            return HSQLServer;
        }


        public SqlConnection getConnection() {
            string connectionString = "Data Source=192.168.1.37;Initial Catalog=DB_PATRONES;User ID=sa;Password=System2k19";

            if(oConnection == null) {
                oConnection = new SqlConnection(connectionString);
                oConnection.Open();
            }

            if(oConnection.State != System.Data.ConnectionState.Open) {
                while(true) {
                    if(oConnection.State == System.Data.ConnectionState.Open) { break; }
                    if(oConnection.State == System.Data.ConnectionState.Broken) { oConnection.Close(); oConnection.Open(); }
                    if(oConnection.State == System.Data.ConnectionState.Closed) { oConnection.Open(); }
                }
            }

            return oConnection;
        }


    }
}
