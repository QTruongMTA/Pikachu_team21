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
        private int numLevel = 2;
        Timer timer = new Timer();

        private static int[,] lv2 = MatrixGenerator.Instance.CreateDisplayMatrix(12, 16);
        LevelData level2 = new LevelData(lv2, 36, 500);
        public level02()
        {
            InitializeComponent();
            
        }

        private void level02_Load(object sender, EventArgs e)
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
            main.SetData(level2.Matrix);
            main.Show();
            this.Close();
        }
    }
}
