using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPatrones.BusinessLogic
{
    class Users
    {
        DataAccess.UsersDAO UserDAO;

        public Users() {
            UserDAO = new DataAccess.UsersDAO();
        }

        public DataSet getListUsers()
        {
            return UserDAO.getListUsers();
        }

        public int setUsers(Entities.E_Users user) {
            return UserDAO.setUsers(user);
        }


    }
}
