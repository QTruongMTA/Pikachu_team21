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
    public partial class frmKetThucMan: Form
    {
        public frmKetThucMan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateLabel1()
        {
            if (Player.Instance.Thoigian() > 0)
            {
                label1.Text = "XUAT SAC!!!";
            }
            else
            {
                label1.Text = "CO GANG LAN SAU NHA!!!";
            }
        }

        public void UpdateLabel2()
        {
            label2.Text = $"Ten: {Player.Instance.Ten()}\n" +
                          $"Cap Do: {Player.Instance.Capdo()}\n" +
                          $"So Diem: {Player.Instance.Diem()}\n" +
                          $"Thoi Gian: {Player.Instance.Thoigian()}s"
                          ;
        }
        private void frmGameOver_Load(object sender, EventArgs e)
        {
            UpdateLabel1();
            UpdateLabel2();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.UpdateLabel();
            frmHome.ShowDialog();
            Close();
        }
    }
}
