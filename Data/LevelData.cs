using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class LevelData
    {
        int[,] matrix;
        int soPic;
        long baseTime;
        public LevelData(int[,] matrix, int soPic, long baseTime)
        {
            this.matrix = matrix;
            this.soPic = soPic;
            this.baseTime = baseTime;
        }
        public int[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public int SoPic
        {
            get { return soPic; }
            set { soPic = value; }
        }
        public long BaseTime
        {
            get { return baseTime; }
            set { baseTime = value; }
        }

        private static LevelData level1 = new LevelData(MatrixGenerator.Instance.CreateDisplayMatrix(9, 16), 36, 500);
        public static LevelData Level1
        {
            get { return level1; }
        }
        private static LevelData level2 = new LevelData(MatrixGenerator.Instance.CreateDisplayMatrix(12, 16), 36, 500);
        public static LevelData Level2
        {
            get { return level2; }
        }
        private static LevelData level3 = new LevelData(MatrixGenerator.Instance.CreateDisplayMatrix(9, 16), 47, 300);
        public static LevelData Level3
        {
            get { return level3; }
        }

        private static LevelData _instance;
        public static LevelData Instance
        {
            get
            {
                switch (Player.Instance.NumLevel())
                {
                    case 1:
                        _instance = level1;
                        break;
                    case 2:
                        _instance = level2;
                        break;
                    case 3:
                        _instance = level3;
                        break;
                    default:
                        _instance = new LevelData(MatrixGenerator.Instance.CreateDisplayMatrix(9, 16), 36, 500);
                        break;
                }
                return _instance;
            }
        }
    }
}
