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
        private readonly List<Bitmap> images = LoadImages();
        private PathFinding pathFinder;

        private GameMatrix() { }

        private static readonly Dictionary<int, Bitmap> imageCache = new Dictionary<int, Bitmap>();
        

        static Bitmap ConvertToBitmap(byte[] byteArray)
        {
            if (!IsValidImage(byteArray))
            {
                
                return new Bitmap(1, 1);
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms);
            }
        }
        private static bool IsValidImage(byte[] byteArray)
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

        private static Bitmap GetImage(int index)
        {
            if (!imageCache.ContainsKey(index))
            {
                string resourceName = $"pic{index}";
                var resource = Properties.Resources.ResourceManager.GetObject(resourceName);
                if(index < 47)
                {
                    if (resource is byte[] byteArray)
                    {
                        imageCache[index] = ConvertToBitmap(byteArray);
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

        private static List<Bitmap> LoadImages()
        {
            var imageList = new List<Bitmap>();
            for (int i = 1; i <= MAX_POKEMON; i++)
            {
                try
                {
                    imageList.Add(GetImage(i));
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    imageList.Add(new Bitmap(1, 1));
                }
            }
            return imageList;
        }

        public void RemoveCell(PictureBox picture)
        {
            picture.Visible = false;
            picture.Tag = 0;
        }

        public List<Point> PathConnect(Point start, Point end)
        {
            if (pathFinder == null)
            {
                MessageBox.Show("PathFinder chưa được khởi tạo. Hãy gọi phương thức Display() trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var allPaths = pathFinder.FindPaths(start, end, 2);

            var firstValidPath = allPaths?.FirstOrDefault();
            Console.WriteLine("PathConnect result: " + (firstValidPath == null ? "null" : string.Join(" -> ", firstValidPath.Select(p => $"({p.X}, {p.Y})"))));
            return firstValidPath;
        }

        public int GetImageIndex(Image img)
        {
            for (int i = 0; i < images.Count; i++)
            {
                if (images[i] == img)
                    return i;
            }
            return -1;
        }
        public Image GetImageByIndex(int index)
        {
            if (index >= 0 && index < images.Count)
                return images[index];
            return null;
        }
        public void Display(Panel panel, int[,] displayMatrix)
        {
            Random random = new Random();
            Size size = new Size(35, 35);
            int rows = displayMatrix.GetLength(0);
            int cols = displayMatrix.GetLength(1);
            int totalCells = (rows - 2) * (cols - 2);
            foreach (var pb in listPictureBox)
            {
                //if (pb.Image != null)
                //{
                //    pb.Image.Dispose();
                //    pb.Image = null;
                //}
                pb.Dispose();
            }
            panel.Controls.Clear();
            listPictureBox.Clear();

            int totalPairs = totalCells / 2;
            int pairsPerPokemon = totalPairs / SoPokemon;
            int extraPairs = totalPairs % SoPokemon;

            List<int> imageIndexes = new List<int>();
            for (int i = 0; i < SoPokemon; i++)
            {
                int count = pairsPerPokemon * 2 + (i < extraPairs ? 2 : 0);
                for (int j = 0; j < count; j++)
                {
                    imageIndexes.Add(i);
                }
            }
            while (imageIndexes.Count < totalCells)
                imageIndexes.Add(0);

            imageIndexes = imageIndexes.OrderBy(x => random.Next()).ToList();

            int index = 0;
            for (int row = 1; row < rows - 1; row++)
            {
                for (int col = 1; col < cols - 1; col++)
                {
                    int imageIndex = imageIndexes[index++];
                    PictureBox pictureBox = CreatePictureBox(row, col, size, imageIndex);
                    panel.Controls.Add(pictureBox);
                    listPictureBox.Add(pictureBox);
                }
            }
            Border(panel, displayMatrix, "up");
            Border(panel, displayMatrix, "down");
            Border(panel, displayMatrix, "left");
            Border(panel, displayMatrix, "right");
            pathFinder = new PathFinding(listPictureBox);
        }

        public void Border(Panel panel, int[,] displayMatrix, string s)
        {
            Size size = new Size(35, 35);
            int rows = displayMatrix.GetLength(0);
            int cols = displayMatrix.GetLength(1);

            int startRow = 0;
            int endRow = rows;
            int startCol = 0;
            int endCol = cols;

            if (s == "up")
            {
                endCol = 1;
            }
            if (s == "down")
            {
                startCol = cols - 1;
            }
            if (s == "left")
            {
                endRow = 1;
                startCol = 1;
                endCol = cols - 1;
            }
            if (s == "right")
            {
                startRow = rows - 1;
                startCol = 1;
                endCol = cols - 1;
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
        private PictureBox CreatePictureBox(int row, int col, Size size, int imageIndex)
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

            pictureBox.Click += (sender, e) => Event.PictureBox_Click(sender, e);
            pictureBox.MouseEnter += (sender, e) => Event.PictureBox_MouseEnter(sender, e);
            pictureBox.MouseLeave += (sender, e) => Event.PictureBox_MouseLeave(sender, e);

            return pictureBox;
        }

        public void Shuffle()
        {
            if (listPictureBox.Count == 0)
            {
                MessageBox.Show("Không có hình ảnh nào để xáo trộn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Image> visibleImages = new List<Image>();
            foreach (var pictureBox in listPictureBox)
            {
                if (pictureBox.Visible && pictureBox.Image != null)
                {
                    visibleImages.Add(pictureBox.Image);
                }
            }

            Random random = new Random();
            for (int i = visibleImages.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (visibleImages[i], visibleImages[j]) = (visibleImages[j], visibleImages[i]);
            }

            int index = 0;
            foreach (var pictureBox in listPictureBox)
            {
                if (pictureBox.Visible && pictureBox.Image != null)
                {
                    pictureBox.Image = visibleImages[index];
                    index++;
                }
            }
        }
        public List<PictureBox> GetPictureBoxes()
        {
            return listPictureBox;
        }
    }
}
    
