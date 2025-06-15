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
    class GameMatrix
    {
        public const int MAX_POKEMON = 46;
        private static GameMatrix _instance;

        private static readonly object _lock = new object();
        public static GameMatrix Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new GameMatrix();
                        }
                    }
                }
                return _instance;
            }
        }

        private int soPokemon = 36;
        public int SoPokemon
        {
            get { return soPokemon; }
            set { soPokemon = value; }
        }
        private readonly List<PictureBox> listPictureBox = new List<PictureBox>();
        private readonly List<Bitmap> images = Load_HinhAnh();
        private PathFinding pathFinder;
        private int soLanDoiChieu = 2;

        public int SoLanDoiChieu
        {
            get { return soLanDoiChieu; }
            set { soLanDoiChieu = value; }
        }

        private GameMatrix() { }

        private static readonly Dictionary<int, Bitmap> imageCache = new Dictionary<int, Bitmap>();
        

        static Bitmap EpByte_Bitmap(byte[] byteArray)
        {
            if (!IsAnhHople(byteArray))
            {
                
                return new Bitmap(1, 1);
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms);
            }
        }
        private static bool IsAnhHople(byte[] byteArray)
        {
            try
            {
                using (var ms = new MemoryStream(byteArray))
                using (var img = Image.FromStream(ms, false, true))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static Bitmap Get_HinhAnh(int index)
        {
            if (!imageCache.ContainsKey(index))
            {
                string resourceName = $"pic{index}";
                var resource = Properties.Resources.ResourceManager.GetObject(resourceName);
                if(index < 47)
                {
                    if (resource is byte[] byteArray)
                    {
                        imageCache[index] = EpByte_Bitmap(byteArray);
                    }
                    else
                    {
                        Console.WriteLine($"Warning: Resource {resourceName} not found. Using placeholder image.");
                        imageCache[index] = new Bitmap(1, 1);
                    }
                }
                
            }
            return imageCache[index];
        }

        private static List<Bitmap> Load_HinhAnh()
        {
            var imageList = new List<Bitmap>();
            for (int i = 1; i <= MAX_POKEMON; i++)
            {
                try
                {
                    imageList.Add(Get_HinhAnh(i));
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    imageList.Add(new Bitmap(1, 1));
                }
            }
            return imageList;
        }

        public void XoaHinhAnhHople(PictureBox picture)
        {
            picture.Visible = false;
            picture.Tag = 0;
        }

        public List<Point> DuongNoi(Point start, Point end)
        {
            if (pathFinder == null)
            {
                MessageBox.Show("PathFinder chưa được khởi tạo. Hãy gọi phương thức Display() trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var allPaths = pathFinder.FindPaths(start, end, soLanDoiChieu);

            var firstValidPath = allPaths?.FirstOrDefault();
            Console.WriteLine("Ket qua duong noi: " + (firstValidPath == null ? "null" : string.Join(" -> ", firstValidPath.Select(p => $"({p.X}, {p.Y})"))));
            return firstValidPath;
        }
        
        public void HienThi(Panel panel, int[,] matranHienThi)
        {
            Random random = new Random();
            Size size = new Size(48, 48);
            int hangs = matranHienThi.GetLength(0);
            int cots = matranHienThi.GetLength(1);
            int tongSoBox = (hangs - 2) * (cots - 2);
            foreach (var pb in listPictureBox)
            {
                pb.Dispose();
            }
            panel.Controls.Clear();
            listPictureBox.Clear();

            int tongSoCap = tongSoBox / 2;
            int cap_moiPokemon = tongSoCap / SoPokemon;
            int capNgoaiLe = tongSoCap % SoPokemon;

            List<int> sohieuHinhAnh = new List<int>();
            for (int i = 0; i < SoPokemon; i++)
            {
                int count = cap_moiPokemon * 2 + (i < capNgoaiLe ? 2 : 0);
                for (int j = 0; j < count; j++)
                {
                    sohieuHinhAnh.Add(i);
                }
            }
            while (sohieuHinhAnh.Count < tongSoBox)
                sohieuHinhAnh.Add(0);

            sohieuHinhAnh = sohieuHinhAnh.OrderBy(x => random.Next()).ToList();

            int index = 0;
            for (int hang = 1; hang < hangs - 1; hang++)
            {
                for (int cot = 1; cot < cots - 1; cot++)
                {
                    int so_HinhAnh = sohieuHinhAnh[index++];
                    PictureBox pictureBox = TaoPicBox(hang, cot, size, so_HinhAnh);
                    panel.Controls.Add(pictureBox);
                    listPictureBox.Add(pictureBox);
                }
            }
            VienMatran(panel, matranHienThi, "up");
            VienMatran(panel, matranHienThi, "down");
            VienMatran(panel, matranHienThi, "left");
            VienMatran(panel, matranHienThi, "right");
            pathFinder = new PathFinding(listPictureBox);
        }

        public void VienMatran(Panel panel, int[,] matranHienThi, string s)
        {
            Size size = new Size(48, 48);
            int hangs = matranHienThi.GetLength(0);
            int cots = matranHienThi.GetLength(1);

            int startRow = 0;
            int endRow = hangs;
            int startCol = 0;
            int endCol = cots;

            if (s == "up")
            {
                endCol = 1;
            }
            if (s == "down")
            {
                startCol = cots - 1;
            }
            if (s == "left")
            {
                endRow = 1;
                startCol = 1;
                endCol = cots - 1;
            }
            if (s == "right")
            {
                startRow = hangs - 1;
                startCol = 1;
                endCol = cots - 1;
            }

            for (int row = startRow; row < endRow; row++)
            {
                for (int col = startCol; col < endCol; col++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = size,
                        Location = new Point(col * size.Width, row * size.Height),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.LemonChiffon,
                        Visible = false,
                        Tag = 0,
                    };
                    panel.Controls.Add(pictureBox);
                    listPictureBox.Add(pictureBox);
                }
            }
        }
        private PictureBox TaoPicBox(int row, int col, Size size, int imageIndex)
        {
            PictureBox pictureBox = new PictureBox
            {
                Size = size,
                Location = new Point(col * size.Width, row * size.Height),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LemonChiffon,
                Visible = true,
                Tag = 1,
            };

            pictureBox.Image = images[imageIndex];
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox.Click += (sender, e) => SuKien.PictureBox_Click(sender, e);
            pictureBox.MouseEnter += (sender, e) => SuKien.PictureBox_MouseEnter(sender, e);
            pictureBox.MouseLeave += (sender, e) => SuKien.PictureBox_MouseLeave(sender, e);

            return pictureBox;
        }

        public void TronAnh()
        {
            if (listPictureBox.Count == 0)
            {
                MessageBox.Show("Không có hình ảnh nào để xáo trộn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Image> AnhHien = new List<Image>();
            foreach (var pictureBox in listPictureBox)
            {
                if (pictureBox.Visible && pictureBox.Image != null)
                {
                    AnhHien.Add(pictureBox.Image);
                }
            }

            Random random = new Random();
            for (int i = AnhHien.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (AnhHien[i], AnhHien[j]) = (AnhHien[j], AnhHien[i]);
            }

            int index = 0;
            foreach (var pictureBox in listPictureBox)
            {
                if (pictureBox.Visible && pictureBox.Image != null)
                {
                    pictureBox.Image = AnhHien[index];
                    index++;
                }
            }
        }
        public List<PictureBox> Get_ListPicbox()
        {
            return listPictureBox;
        }
    }
}
    
