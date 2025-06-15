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
            string text = Player.Instance.Ten();
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
            frmHuongDan frmGuide = new frmHuongDan();
            frmGuide.Show();
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            var state = TrangThai.Instance.LoadGame(Player.Instance.Ten());
            if (state.stateList == null)
            {
                MessageBox.Show("Không có trạng thái game cũ để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmMain.Instance.Is_Tailai = true; // Đánh dấu là đang load trạng thái

            frmMain.Instance.SetData(MaTranGoc.Instance.TaoMatranGoc(8, 12));
            GameMatrix.Instance.HienThi(frmMain.Instance.Panel3(), frmMain.Instance.Data());

            var picBoxes = GameMatrix.Instance.Get_ListPicbox();
            for (int i = 0; i < state.stateList.Count && i < picBoxes.Count; i++)
            {
                int visible = (int)state.stateList[i];
                picBoxes[i].Visible = (visible == 1);
                picBoxes[i].Tag = visible;
            }

            frmMain.Instance.Score = state.diem;
            Player.Instance.SetCapdo(state.capDo);
            frmMain.Instance.TimeRemain = state.thoiGianCon;
            Player.Instance.SetTen(state.ten);
            frmMain.Instance.UpLabel(state.capDo);

            frmMain.Instance.Show();
            this.Close();
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
