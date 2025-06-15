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
    public partial class frmTamDung : Form
    {
        public frmTamDung()
        {
            InitializeComponent();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            frmMain.Instance.Show();
            frmMain.Instance.GameTimer.Start();

            foreach (Control c in frmMain.Instance.Panel3().Controls)
            {
                if (c is PictureBox)
                    c.Enabled = true;
            }

            frmMain.Instance.BtnSuffle.Enabled = true;
            frmMain.Instance.BtnHint.Enabled = true;
            frmMain.Instance.BtnReset.Enabled = true;
            frmMain.Instance.Button1.Enabled = true;
            frmMain.Instance.Button2.Enabled = true;

            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmOutSave outSave = new frmOutSave();
            outSave.Show();
        }
    }
}
