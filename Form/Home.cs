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
    public partial class frmHome: Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        public void UpdateLabel()
        {
            string text = Player.Instance.Name();
            if (text == "") text = "NONAME";
            lblWelcome.Text = "CHIẾN THÔI\n" + text + " CUTE ƠI!!!";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmLevel01 lvform = new frmLevel01();

            lvform.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmOutSave outSave = new frmOutSave();
            outSave.Show();
            this.Close();
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            frmGuide frmGuide = new frmGuide();
            frmGuide.Show();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            var state = GameStates.Instance.LoadGame(Player.Instance.Name());
            if (string.IsNullOrEmpty(state.name))
            {
                MessageBox.Show("Không có trạng thái game cũ để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmMain mainForm = new frmMain();

            mainForm.Score = state.score;
            Player.Instance.SetNumLevel(state.level);
            mainForm.TimeRemain = state.timeRemain;

            mainForm.SetData(MatrixGenerator.Instance.CreateDisplayMatrix(state.rows, state.cols));
            GameMatrix.Instance.Display(mainForm.Panel3(), mainForm.Data());

            List<PictureBox> playCells = GameMatrix.Instance.GetPictureBoxes();
            var cellStates = state.cellStates;

            if (playCells.Count != cellStates.Count)
            {
                MessageBox.Show("Dữ liệu lưu và số lượng ô hiện tại không khớp!\nKhông thể tiếp tục game.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < playCells.Count; i++)
            {
                var pb = playCells[i];
                var cell = cellStates[i];
                pb.Visible = cell.visible;
                pb.Tag = cell.visible ? 1 : 0;
                pb.Image = GameMatrix.Instance.GetImageByIndex(cell.imageIndex);
            }

            mainForm.UpLabel(Player.Instance.NumLevel());

            mainForm.Show();
            this.Hide();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            frmTop frmTop = new frmTop();
            frmTop.Show();
            this.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
