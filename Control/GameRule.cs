using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class GameRule
    {
        private readonly GameMatrix gameMatrix;

        public GameRule(GameMatrix gameMatrix)
        {
            this.gameMatrix = gameMatrix;
        }

        public void CheckWin()
        {
            var boxes = gameMatrix.GetPictureBoxes()
                .Where(pb => pb.Visible && Convert.ToInt32(pb.Tag) == 1)
                .ToList();

            foreach (var box in boxes)
            {
                if (box.Visible) return;
            }

            var over = new frmGameOver();
            over.ShowDialog();
            frmMain.Instance.Close();
        }

        public bool CheckSuff()
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
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void AutoSuff() 
        {
            if (CheckSuff()==false)
            {
                gameMatrix.Shuffle();
            }
        }

    }
}
