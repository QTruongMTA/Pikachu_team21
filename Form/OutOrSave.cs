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

namespace Pikachu_team21
{
    public partial class frmOutSave: Form
    {
        public frmOutSave()
        {
            InitializeComponent();
        }

        private void frmOutSave_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var picBoxes = GameMatrix.Instance.Get_ListPicbox();
            TrangThai.Instance.SaveGame(
                Player.Instance.Ten(),
                frmMain.Instance.Score,
                Player.Instance.Capdo(),
                frmMain.Instance.TimeRemain,
                picBoxes
            );

            MessageBox.Show("Đã lưu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmDongGame frmOut = new frmDongGame();
            frmOut.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cl = MessageBox.Show("Lần sau chơi lại là phải chơi từ đầu đó!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cl == DialogResult.OK) 
            {
                frmDongGame frmOut = new frmDongGame();
                frmOut.Show();
                this.Close();
            }
            
        }
    }
}
