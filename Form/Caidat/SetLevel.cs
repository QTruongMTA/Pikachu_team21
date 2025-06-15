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
    public partial class frmSetLevel : Form
    {
        private static frmSetLevel _instance;
        public static frmSetLevel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmSetLevel();
                }
                return _instance;
            }
        }

        public frmSetLevel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLevel01 levelForm = new frmLevel01();
            levelForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level02 level02 = new level02();
            level02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level03 level03 = new level03();
            level03.Show();
        }
    }
}
