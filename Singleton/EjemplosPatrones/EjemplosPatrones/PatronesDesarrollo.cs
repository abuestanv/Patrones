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
    public partial class PatronesDesarrollo : Form
    {
        public PatronesDesarrollo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatronSingelton oSingleton = new PatronSingelton();
            oSingleton.ShowDialog();

        }


    }
}
