using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPatrones
{
    public partial class PatronSingelton
    {

        private void getUsers() 
        {
            var oDataSet = UserLogic.getListUsers();
            if (oDataSet != null) {
                if (oDataSet.Tables != null) {
                    grdUsers.DataSource = oDataSet.Tables[0];
                }
            }

        }

        private Entities.E_Users getUser() {
            var user = new Entities.E_Users();
            user.UserId = Convert.ToInt32(etUserId.Text);
            user.UserName = etUserName.Text;
            user.Email = etEmail.Text;
            user.Password = etPassword.Text;

            return user;
        }


        private void UserAsignar() {
            etUserId.Text = Convert.ToString(grdUsers.CurrentRow.Cells[0].Value);
            etUserName.Text = Convert.ToString(grdUsers.CurrentRow.Cells[2].Value);
            etEmail.Text = Convert.ToString(grdUsers.CurrentRow.Cells[3].Value);
            etPassword.Text = Convert.ToString(grdUsers.CurrentRow.Cells[4].Value);

        }



    }


}
