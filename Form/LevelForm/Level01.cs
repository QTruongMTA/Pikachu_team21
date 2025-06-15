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
using System.Media;
using System.IO;
using System.Reflection;
using Pikachu_team21;
using System.Xml.Linq;

namespace Pikachu_team21
{
    public partial class frmLevel01 : Form
    {
        Timer timer = new Timer();

        public frmLevel01()
        {
            InitializeComponent();
        }

        private void frmLevel01_Load(object sender, EventArgs e)
        {
            timer.Interval = 1200;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Player.Instance.SetCapdo(1);
            frmMain main = new frmMain();
            main.UpLabel(Player.Instance.Capdo());
            main.SetData(LevelData.Level1.Matrix);
            main.Show();
            this.Close();
        }
    }
}
