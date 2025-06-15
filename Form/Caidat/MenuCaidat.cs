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
    public partial class frmMenuCaidat : Form
    {
        public frmMenuCaidat()
        {
            InitializeComponent();
        }

        private void lblSetMethod_Click(object sender, EventArgs e)
        {

        }

        private void btnSetMethod_Click(object sender, EventArgs e)
        {
            frmSetting settingForm = new frmSetting();
            settingForm.Show();
        }

        private void btnSetLevel_Click(object sender, EventArgs e)
        {
            frmSetLevel levelForm = new frmSetLevel();
            levelForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain mainForm = frmMain.Instance;
            mainForm.Show();
            Close();
        }
    }
}
