using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;
using NAudio.Wave;

namespace Pikachu_team21
{
    public partial class frmDangNhap : Form
    {
        AmThanh sound = AmThanh.Instance;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            sound.PlaySou("TitleSound01");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            Player.Instance.SetTen(txtPlayerName.Text);
            frmHome home = new frmHome();
            home.UpdateLabel();
            home.Show();
            this.Hide();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerName.Text.Length > 10)
            {
                MessageBox.Show("Tên không được quá 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPlayerName.Text = txtPlayerName.Text.Substring(0, 10);
            }
        }
    }
}
