using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class Hint
    {
        private readonly GameMatrix gameMatrix;

        public Hint(GameMatrix gameMatrix)
        {
            this.gameMatrix = gameMatrix;
        }

        /// <param name="overlayPanel">Panel dùng để vẽ đường đi gợi ý (ví dụ: panel4).</param>
        public bool ShowHint(Panel overlayPanel)
        {
            var boxes = gameMatrix.GetPictureBoxes()
                .Where(pb => pb.Visible && Convert.ToInt32(pb.Tag) == 1)
                .ToList();

            for (int i = 0; i < boxes.Count; i++)
            {
                for (int j = i + 1; j < boxes.Count; j++)
                {
                    if (boxes[i].Image == boxes[j].Image)
                    {
                        var path = gameMatrix.PathConnect(boxes[i].Location, boxes[j].Location);
                        if (path != null && path.Count > 1)
                        {
                            var p1 = (Point)boxes[i].Tag;
                            var p2 = (Point)boxes[j].Tag;

                            HighlightBoxes(boxes[i], boxes[j]);
                            return true;
                        }
                    }
                }
            }
            MessageBox.Show("Không còn nước đi hợp lệ!", "Gợi ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void HighlightBoxes(PictureBox pb1, PictureBox pb2)
        {
            Color oldColor1 = pb1.BackColor;
            Color oldColor2 = pb2.BackColor;
            pb1.BackColor = Color.Yellow;
            pb2.BackColor = Color.Yellow;

            Timer timer = new Timer { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                pb1.BackColor = oldColor1;
                pb2.BackColor = oldColor2;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
}
