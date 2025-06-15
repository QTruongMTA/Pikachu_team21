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
    public partial class frmTop: Form
    {
        public frmTop()
        {
            InitializeComponent();
        }

        private void frmTop_Load(object sender, EventArgs e)
        {
            var allPlayers = DanhSachNguoiChoi.GetPlayers();
            var top3 = DanhSachNguoiChoi.GetTop3(allPlayers);

            lblTop1Text.Text = "Chưa có dữ liệu";
            lblTop2Text.Text = "Chưa có dữ liệu";
            lblTop3Text.Text = "Chưa có dữ liệu";

            if (top3.Count > 0)
            {
                var p = top3[0];
                lblTop1Text.Text = $"1. {p.Ten()} - Điểm: {p.Diem()} - TG còn: {p.Thoigian()}s";
            }
            if (top3.Count > 1)
            {
                var p = top3[1];
                lblTop2Text.Text = $"2. {p.Ten()} - Điểm: {p.Diem()} - TG còn: {p.Thoigian()}s";
            }
            if (top3.Count > 2)
            {
                var p = top3[2];
                lblTop3Text.Text = $"3. {p.Ten()} - Điểm: {p.Diem()} - TG còn: {p.Thoigian()}s";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
