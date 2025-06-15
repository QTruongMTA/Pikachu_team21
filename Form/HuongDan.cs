using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    public partial class frmHuongDan : Form
    {
        private List<Image> huongDanImages;
        private int currentImageIndex = 0;

        public frmHuongDan()
        {
            InitializeComponent();
            LoadHDImages();
            ShowCrImage();
        }

        private void LoadHDImages()
        {
            huongDanImages = new List<Image>
            {
                Properties.Resources.hoenn,
                Properties.Resources.kanto,
                Properties.Resources.Over

            };
        }

        private void ShowCrImage()
        {
            if (huongDanImages != null && huongDanImages.Count > 0)
            {
                pbHuongDan.Image = huongDanImages[currentImageIndex];
            }
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            if (huongDanImages == null || huongDanImages.Count == 0) return;
            currentImageIndex = (currentImageIndex + 1) % huongDanImages.Count;
            ShowCrImage();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            if (huongDanImages == null || huongDanImages.Count == 0) return;
            currentImageIndex = (currentImageIndex - 1 + huongDanImages.Count) % huongDanImages.Count;
            ShowCrImage();
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.UpdateLabel();
            frmHome.Show();
            Close();
        }
    }
}
