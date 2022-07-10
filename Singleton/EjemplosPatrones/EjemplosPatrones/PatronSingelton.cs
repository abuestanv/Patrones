using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosPatrones
{
    public partial class PatronSingelton : Form
    {
        BusinessLogic.Users UserLogic { get; set; }
        public PatronSingelton()
        {
            InitializeComponent();
            UserLogic = new BusinessLogic.Users();
        }

        private void PatronSingelton_Load(object sender, EventArgs e)
        {
            getUsers();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (grdUsers.CurrentRow != null) {
                UserAsignar();
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            var user = getUser();
            UserLogic.setUsers(user);

            getUsers();
        }



    }
}
