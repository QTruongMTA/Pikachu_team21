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
    public partial class level03: Form
    {

        private int numLevel = 3;
        Timer timer = new Timer();
        private static int[,] lv3 = MatrixGenerator.Instance.CreateDisplayMatrix(9, 16);
        LevelData level3 = new LevelData(lv3, 47, 300);
        public level03()
        {
            InitializeComponent();
        }

        private void level03_Load(object sender, EventArgs e)
        {
            timer.Interval = 1200;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            frmMain main = new frmMain();
            main.UpLabel(numLevel);
            main.SetData(level3.Matrix);
            main.Show();
            this.Close();
        }
    }
}
