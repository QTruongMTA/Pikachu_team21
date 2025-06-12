using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class Selected
    {
        private PictureBox selection1;
        private PictureBox selection2;
        private readonly GameMatrix gameMatrix;
        private bool isSelected1 = false;
        private bool isSelected2 = false;
        private static Selected _instance = new Selected();
        private bool correct = false;
        public bool Correct => correct;
        public static Selected Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool IsSelected1 => isSelected1;
        public bool IsSelected2 => isSelected2;
        public PictureBox Selection1 => selection1;
        public PictureBox Selection2 => selection2;

        public Selected()
        {
            gameMatrix = GameMatrix.Instance;
        }

        public void SetSelection(PictureBox pictureBox)
        {
            if (selection1 == null)
            {
                selection1 = pictureBox;
                isSelected1 = true;
            }
            else if (selection2 == null)
            {
                selection2 = pictureBox;
                isSelected2 = true;
            }

            if (selection1 != null && selection2 != null )
            {
                if (selection1 != selection2)
                {
                    if (selection1.Image == selection2.Image)
                    {
                        var path = gameMatrix.PathConnect(selection1.Location, selection2.Location);
                        if (path != null && path.Count > 1)
                        {
                            Console.WriteLine("Path found: " + string.Join(" -> ", path.Select(p => $"({p.X}, {p.Y})")));
                            frmMain.Instance.ShowPath(path);
                            gameMatrix.RemoveCell(selection1);
                            gameMatrix.RemoveCell(selection2);
                            //Sound.Instance.PlayEffect("CorrectSound"); //fix độ dài sound
                            isSelected1 = false;
                            isSelected2 = false;
                            correct = true;
                            var win = new GameRule(GameMatrix.Instance);
                            win.CheckWin();
                            

                        }
                        else
                        {
                            //MessageBox.Show("Không thể kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Reset();
                            //Sound.Instance.PlayEffect("ErrorSound");
                            correct = false;
                        }
                    }
                    else
                    {
                        Reset();
                        correct = false;
                    }
                }
                else
                {
                    Reset();
                    correct = false;
                }
                Reset();

            }
            var suff = new GameRule(GameMatrix.Instance);
            suff.AutoSuff();
        }
        private void Reset()
        {
            isSelected1 = false;
            selection1 = null;

            isSelected2 = false;
            selection2 = null;
            
        }

        public void inCorrect()
        {
            correct = false;
        }
    }
}
