using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class Chon
    {
        private PictureBox chon1;
        private PictureBox chon2;
        private readonly GameMatrix matranGame;
        private bool is_chon1 = false;
        private bool is_chon2 = false;
        private static Chon _instance = new Chon();
        private bool hople = false;
        public bool Hople => hople;
        public static Chon Instance
        {
            get
            {
                return _instance;
            }
        }

        public bool Is_chon1 => is_chon1;
        public bool Is_chon2 => is_chon2;
        public PictureBox Chon1 => chon1;
        public PictureBox Chon2 => chon2;

        public Chon()
        {
            matranGame = GameMatrix.Instance;
        }

        public void LuaChon(PictureBox pictureBox)
        {
            if (chon1 == null)
            {
                chon1 = pictureBox;
                is_chon1 = true;
            }
            else if (chon2 == null)
            {
                chon2 = pictureBox;
                is_chon2 = true;
            }

            if (chon1 != null && chon2 != null )
            {
                if (chon1 != chon2)
                {
                    if (chon1.Image == chon2.Image)
                    {
                        var path = matranGame.DuongNoi(chon1.Location, chon2.Location);
                        if (path != null && path.Count > 1)
                        {
                            Console.WriteLine("Duong tim thay: " + string.Join(" -> ", path.Select(p => $"({p.X}, {p.Y})")));
                            frmMain.Instance.XemDuong(path);
                            matranGame.XoaHinhAnhHople(chon1);
                            matranGame.XoaHinhAnhHople(chon2);
                            //Sound.Instance.PlayEffect("CorrectSound"); //fix độ dài sound
                            is_chon1 = false;
                            is_chon2 = false;
                            hople = true;
                            var win = new LuatChoi(GameMatrix.Instance);
                            win.KtraWin();

                        }
                        else
                        {
                            //MessageBox.Show("Không thể kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Reset();
                            //Sound.Instance.PlayEffect("ErrorSound");
                            hople = false;
                        }
                    }
                    else
                    {
                        Reset();
                        hople = false;
                    }
                }
                else
                {
                    Reset();
                    hople = false;
                }
                Reset();
            }
            var suff = new LuatChoi(GameMatrix.Instance);
            suff.TudongTron();
        }
        private void Reset()
        {
            if (chon1 != null)
            {
                chon1.BackColor = Color.LemonChiffon;
                chon1.BorderStyle = BorderStyle.FixedSingle;
            }
            if (chon2 != null)
            {
                chon2.BackColor = Color.LemonChiffon;
                chon2.BorderStyle = BorderStyle.FixedSingle;
            }
            is_chon1 = false;
            chon1 = null;
            is_chon2 = false;
            chon2 = null;
        }

        public void KhongHople()
        {
            hople = false;
        }
    }
}
