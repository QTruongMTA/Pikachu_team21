using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Pikachu_team21
{
    public partial class frmSetting : Form
    {
        private static frmSetting _instance;
        private int selectedSoPokemon;
        private int time;
        public static frmSetting Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmSetting();
                }
                return _instance;
            }
        }

        public frmSetting()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uki bạn nha! Apply liền nè!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GameMatrix.Instance.SoPokemon = selectedSoPokemon;
            frmMain.Instance.TimeRemain = time;

            frmMain.Instance.SetData(MatrixGenerator.Instance.CreateDisplayMatrix(9, 16));
            GameMatrix.Instance.Display(frmMain.Instance.Panel3(), frmMain.Instance.Data());

            this.Close();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }

        private void updLevel_SelectedItemChanged(object sender, EventArgs e)
        {
            /*if (updLevel.SelectedItem.ToString() == "Dễ")
            {
                frmLevel01 frmLevel01 = new frmLevel01();
                frmLevel01.Show();
            }
            if (updLevel.SelectedItem.ToString() == "Trung bình")
            {
                level02 frmLevel02 = new level02();
                frmLevel02.Show();
            }
            if (updLevel.SelectedItem.ToString() == "Khó")
            {
                level03 frmLevel03 = new level03();
                frmLevel03.Show();
            }*/
        }

        private void updMusic_SelectedItemChanged(object sender, EventArgs e)
        {
            if (updMusic.SelectedItem.ToString() == "Theme01") 
            {
                Sound.Instance.PlaySou("TitleSound01");
            }
            if (updMusic.SelectedItem.ToString() == "Theme02")
            {
                Sound.Instance.PlaySou("TitleSound02");
            }
            if (updMusic.SelectedItem.ToString() == "Theme03")
            {
                Sound.Instance.PlaySou("TitleSound03");
            }
            if (updMusic.SelectedItem.ToString() == "Theme04")
            {
                Sound.Instance.PlaySou("TitleSound04");
            }
            if (updMusic.SelectedItem.ToString() == "Theme05")
            {
                Sound.Instance.PlaySou("TitleSound05");
            }
        }

        private void updTime_SelectedItemChanged(object sender, EventArgs e)
        {
        
            if (updTime.SelectedItem.ToString() == "300s")
            {
                time = 300;
            }
            if (updTime.SelectedItem.ToString() == "500s")
            {
                time = 500;
            }
            if (updTime.SelectedItem.ToString() == "700s")
            {
                time = 700;
            }
            if (updTime.SelectedItem.ToString() == "Vô hạn")
            {
                time = 10000;
            }
        
            
        }

        private void updPokemon_SelectedItemChanged(object sender, EventArgs e)
        {
            string selected = updPokemon.SelectedItem.ToString();
            if (selected == "8") selectedSoPokemon = 8;
            else if (selected == "16") selectedSoPokemon = 16;
            else if (selected == "24") selectedSoPokemon = 24;
            else if (selected == "36") selectedSoPokemon = 36;
            else if (selected == "46") selectedSoPokemon = 46;
        }

        private void lblSetVol_Click(object sender, EventArgs e)
        {

        }
    }
}
