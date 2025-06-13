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
            try
            {
                List<PictureBox> playCells = GameMatrix.Instance.GetPictureBoxes();
               
                GameStates.Instance.SaveGame(
                    Player.Instance.Name(),
                    Player.Instance.Score(),
                    Player.Instance.NumLevel(),
                    frmMain.Instance.TimeRemain,
                    frmMain.Instance.Data(),
                    playCells
                );

                MessageBox.Show("Lưu game thành công!", "Lưu Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu game: " + ex.Message, "Lưu Game", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Tau nhớ mi rùi nha!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmOut frmOut = new frmOut();
            frmOut.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cl = MessageBox.Show("Lần sau chơi lại là phải chơi từ đầu đó!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (cl == DialogResult.OK) 
            {
                frmOut frmOut = new frmOut();
                frmOut.Show();
                this.Close();
            }
            
        }
    }
}
