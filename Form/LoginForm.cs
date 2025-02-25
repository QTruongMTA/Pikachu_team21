using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            frmLevel01 lvform = new frmLevel01();
            lvform.UpdateLabel(txtPlayerName.Text);
            lvform.Show();
            this.Hide();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
