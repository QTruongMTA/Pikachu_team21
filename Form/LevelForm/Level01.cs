using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    public partial class frmLevel01: Form
    {
        public frmLevel01()
        {
            InitializeComponent();
        }
        public void UpdateLabel(string text)
        {
            lblName.Text = "Xin chào " + text + " nha!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
