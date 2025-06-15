using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class LuatChoi
    {
        private readonly GameMatrix matranGame;
        private static LuatChoi _instance;
        public static LuatChoi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LuatChoi(GameMatrix.Instance);
                }
                return _instance;
            }
        }
        public LuatChoi(GameMatrix matranGame)
        {
            this.matranGame = matranGame;
        }


        public void SetDemChung(int dem, int bom, int hin) 
        { 
            frmMain.Instance.Dem = dem;
            frmMain.Instance.DemBomb = bom;
            frmMain.Instance.DemHint = hin;
        }

        public void KtraWin()
        {
            var boxes = matranGame.Get_ListPicbox()
                .Where(pb => pb.Visible && Convert.ToInt32(pb.Tag) == 1)
                .ToList();

            foreach (var box in boxes)
            {
                if (box.Visible) return;
            }

            var over = new frmKetThucMan();
            over.ShowDialog();
            frmMain.Instance.Close();
        }

        public bool KtraTron()
        {
            var boxes = matranGame.Get_ListPicbox()
                .Where(pb => pb.Visible && Convert.ToInt32(pb.Tag) == 1)
                .ToList();

            for (int i = 0; i < boxes.Count; i++)
            {
                for (int j = i + 1; j < boxes.Count; j++)
                {
                    if (boxes[i].Image == boxes[j].Image)
                    {
                        var path = matranGame.DuongNoi(boxes[i].Location, boxes[j].Location);
                        if (path != null && path.Count > 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void TudongTron() 
        {
            if (KtraTron()==false)
            {
                matranGame.TronAnh();
            }
        }

    }
}
