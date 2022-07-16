using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EjemplosPatrones.DataAccess
{
    class UsersDAO
    {
        private SqlConnection oConnection;

        public UsersDAO() {
            oConnection = Singleton.HelperSQLServer.getInstance().getConnection();
        }

        public DataSet getListUsers() {
            DataSet oDataSet = new DataSet();

            var oAdapter = new SqlDataAdapter("SELECT * FROM USERS", oConnection);
            oAdapter.Fill(oDataSet, "USERS");
            oAdapter.Dispose();

            return oDataSet;
        }

        public int setUsers(Entities.E_Users user) {
            int iResp = 0;

            string SQL = $" UPDATE USERS " + 
                         $"    SET UserName = '{user.UserName}', email = '{user.Email}', [password] = '{user.Password}' " + 
                         $" WHERE UserId = '{user.UserId}' ";

            var oCommand = new SqlCommand(SQL, oConnection);
            iResp = oCommand.ExecuteNonQuery();

            return iResp;
        }



    }
}
