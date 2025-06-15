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
    public partial class frmDongGame: Form
    {

        public frmDongGame()
        {
            InitializeComponent();
        }

        private void frmOut_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                Application.Exit();
        }


        public void UpdateLabel()
        {
            lblBye.Text = "HẸN GẶP LẠI NHA!";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }
    }
}
