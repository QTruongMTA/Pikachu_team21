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
    public partial class level02: Form
    {
        Timer timer = new Timer();
        public level02()
        {
            InitializeComponent();
        }

        private void level02_Load(object sender, EventArgs e)
        {
            timer.Interval = 50;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 4;
            }
            else
            {
                timer.Stop();
                Player.Instance.SetCapdo(2);
                frmMain main = new frmMain();
                main.UpLabel(Player.Instance.Capdo());
                main.SetData(LevelData.Level2.Matrix);
                main.Show();
                this.Close();
            }
        }
    }
}
