using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu_team21
{
    class Bomb
    {
        private readonly GameMatrix gameMatrix;

        public Bomb(GameMatrix gameMatrix)
        {
            this.gameMatrix = gameMatrix;
        }

        public void ActiveBomb()
        {
            var boxes = gameMatrix.GetPictureBoxes()
                .Where(pb => pb.Visible && Convert.ToInt32(pb.Tag) == 1)
                .ToList();

            int pairsToRemove = 2;
            int pairsRemoved = 0;
            var removedIndexes = new HashSet<int>();

            for (int i = 0; i < boxes.Count && pairsRemoved < pairsToRemove; i++)
            {
                if (!boxes[i].Visible || removedIndexes.Contains(i)) continue;

                for (int j = i + 1; j < boxes.Count && pairsRemoved < pairsToRemove; j++)
                {
                    if (!boxes[j].Visible || removedIndexes.Contains(j)) continue;

                    if (boxes[i].Image == boxes[j].Image)
                    {
                        var path = gameMatrix.PathConnect(boxes[i].Location, boxes[j].Location);
                        if (path != null && path.Count > 1)
                        {
                            gameMatrix.RemoveCell(boxes[i]);
                            gameMatrix.RemoveCell(boxes[j]);
                            removedIndexes.Add(i);
                            removedIndexes.Add(j);
                            pairsRemoved++;
                            break;
                        }
                        else
                        {
                            var suff = new GameRule(gameMatrix);
                            suff.AutoSuff();
                        }
                    }
                }
            }
        }
    }
}
