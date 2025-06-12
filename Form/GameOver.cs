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
    public partial class frmGameOver: Form
    {
        public frmGameOver()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateLabel1()
        {
            if (Player.Instance.Time() > 0)
            {
                label1.Text = "YOU WIN";
            }
            else
            {
                label1.Text = "GAME OVER";
            }
        }

        public void UpdateLabel2()
        {
            label2.Text = $"Name: {Player.Instance.Name()}\n" +
                          $"Level: {Player.Instance.NumLevel()}\n" +
                          $"Score: {Player.Instance.Score()}\n" +
                          $"Time: {Player.Instance.Time()}s"
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
