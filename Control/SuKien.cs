using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class SuKien
    {
        public static Chon chon = new Chon();
        public static LuatChoi luat = new LuatChoi(GameMatrix.Instance);

        public static EventHandler PictureBox_Click => (sender, e) =>
        {
            if (sender is PictureBox pictureBox)
            {
                
                pictureBox.BackColor = Color.Red;
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                chon.LuaChon(pictureBox);
                if (chon.Hople == true)
                {
                    frmMain.Instance.CongDiem();
                    chon.KhongHople();
                }
            }
        };

        public static EventHandler PictureBox_MouseEnter => (sender, e) =>
        {
            if (sender is PictureBox pictureBox)
            {
                if ((chon.Is_chon1 && ReferenceEquals(pictureBox, chon.Chon1)) ||
                    (chon.Is_chon2 && ReferenceEquals(pictureBox, chon.Chon2)))
                {
                    return;
                }

                pictureBox.BackColor = Color.Aqua;
            }
        };

        public static EventHandler PictureBox_MouseLeave => (sender, e) =>
        {
            if (sender is PictureBox pictureBox)
            {
                if ((chon.Is_chon1 && ReferenceEquals(pictureBox, chon.Chon1)) ||
                    (chon.Is_chon2 && ReferenceEquals(pictureBox, chon.Chon2)))
                {
                    return;
                }

                pictureBox.BackColor = Color.LemonChiffon;
            }
        };

    }
}
