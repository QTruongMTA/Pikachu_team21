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
    class Event
    {
        public static Selected selected = new Selected();
        public static GameRule gameRule = new GameRule(GameMatrix.Instance);

        public static EventHandler PictureBox_Click => (sender, e) =>
        {
            if (sender is PictureBox pictureBox)
            {
                
                pictureBox.BackColor = Color.Red;
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
                selected.SetSelection(pictureBox);
                if (selected.Correct == true)
                {
                    frmMain.Instance.ScoreUp();
                    selected.inCorrect();
                }
            }
        };

        public static EventHandler PictureBox_MouseEnter => (sender, e) =>
        {
            if (sender is PictureBox pictureBox)
            {
                if ((selected.IsSelected1 && ReferenceEquals(pictureBox, selected.Selection1)) ||
                    (selected.IsSelected2 && ReferenceEquals(pictureBox, selected.Selection2)))
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
                if ((selected.IsSelected1 && ReferenceEquals(pictureBox, selected.Selection1)) ||
                    (selected.IsSelected2 && ReferenceEquals(pictureBox, selected.Selection2)))
                {
                    return;
                }

                pictureBox.BackColor = Color.LemonChiffon;
            }
        };

    }
}
