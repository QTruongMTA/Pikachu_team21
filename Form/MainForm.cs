using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pikachu_team21;

namespace Pikachu_team21
{
    public partial class frmMain : Form
    {
        readonly MaTranGoc matrix = MaTranGoc.Instance;
        readonly GameMatrix gameMatrix = GameMatrix.Instance;
        private readonly frmSetting setting;
        private static frmMain _instance;
        readonly AmThanh sound = AmThanh.Instance;
        private int[,] dataMatrix;
        private long timeRemain;
        private Timer gameTimer;
        private long score = 0;
        private bool is_Tailai = false;
        //private bool isLoadingSavedState = false;

        public bool Is_Tailai
        {
            get { return is_Tailai; }
            set { is_Tailai = value; }
        }
        public long Score
        {
            get { return score; }
            set { score = value; }
        }

        private List<Point> currentPath = null;
        public int[,] Data()
        {
            return dataMatrix;
        }
        public void SetData(int[,] data)
        {
            this.dataMatrix = data;
        }

        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmMain();
                }
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public long TimeRemain
        {
            get { return timeRemain; }
            set { timeRemain = value; }
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (TimeRemain > 0)
            {
                TimeRemain--;
                lblThoigian.Text = $"Thoi Gian: {TimeRemain}s";
                Player.Instance.SetThoigian(TimeRemain);
            }
            else
            {
                gameTimer.Stop();
                frmKetThucMan over = new frmKetThucMan();
                over.ShowDialog();
                Close();
            }
        }
        public void CongDiem()
        {
                Instance.score += 20;
                Instance.lblDiem.Text = $"Diem: {score}";
                Player.Instance.SetDiem(Instance.score);
        }
        public void UpLabel(int num)
        {
            string name = Player.Instance.Ten();
            if (name == "") 
            { 
                name = "noname"; 
            }
            lblTen.Text = "Ten: " + name;

            if (num > 0) { 
                Player.Instance.SetCapdo(num);
                lblCapdo.Text = "Cap Do: " + num;
            }

        }

        public Panel Panel3()
        {
            return panel3;
        }
        public Panel Panel4()
        {
            return panel4;
        }

        public void Form_Load()
        {
            if (!is_Tailai)
            {
                if (Data() == null)
                {
                    SetData(MaTranGoc.Instance.TaoMatranGoc(8, 12));
                }
                gameMatrix.HienThi(panel3, Data());
            }
            switch (Player.Instance.Capdo())
            {
                case 1:
                    TimeRemain = LevelData.Level1.TongThoigian;
                    break;
                case 2:
                    TimeRemain = LevelData.Level2.TongThoigian;
                    break;
                case 3:
                    TimeRemain = LevelData.Level3.TongThoigian;
                    break;
                default:
                    break;
            }

            Instance.lblDiem.Text = $"Diem: {score}";

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += new EventHandler(GameTimer_Tick);

            is_Tailai = false;
        }

        public frmMain()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, panel4, new object[] { true });

            Instance = this; 
            setting = frmSetting.Instance;
            panel4.BringToFront();
            panel4.Visible = true;
            panel4.Paint += panel4_Paint;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmOutSave outSave = new frmOutSave();
            outSave.ShowDialog();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form_Load();
            gameTimer.Start();
            
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            gameMatrix.TronAnh();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (sound.IsPlaying())
            {
                sound.StopSou();
            }
            else 
            {
                List<string> list = new List<String>() { "TitleSound01", "TitleSound02", "TitleSound03", "TitleSound04", "TitleSound05" };
                
                Random random = new Random();
                int i = random.Next(list.Count);
                string s = list[i];
                sound.PlaySou(s);
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            var hint = new Hint(GameMatrix.Instance);
            hint.ShowHint(frmMain.Instance.Panel4());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var bomb = new Bomb(GameMatrix.Instance);
            bomb.KichHoatBom();

        }

        public void XemDuong(List<Point> path)
        {
            currentPath = path;
            panel4.Invalidate();

            Timer timer = new Timer { Interval = 500 };
            timer.Tick += (s, e) =>
            {
                currentPath = null;
                panel4.Invalidate();
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (currentPath == null || currentPath.Count < 2) return;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (var pen = new Pen(Color.Red, 20) { StartCap = System.Drawing.Drawing2D.LineCap.Round, EndCap = System.Drawing.Drawing2D.LineCap.Round })
            {
                for (int i = 0; i < currentPath.Count - 1; i++)
                {
                    Point p1 = new Point(currentPath[i].X * 35 + 17, currentPath[i].Y * 35 + 17);
                    Point p2 = new Point(currentPath[i + 1].X * 35 + 17, currentPath[i + 1].Y * 35 + 17);
                    e.Graphics.DrawLine(pen, p1, p2);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            gameTimer.Stop();
            MessageBox.Show("Dang tam dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
