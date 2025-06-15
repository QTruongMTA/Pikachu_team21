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
        int[,] matranHien;
        int soPic;
        long tongThoigian;
        public LevelData(int[,] matrix, int soPic, long baseTime)
        {
            this.matranHien = matrix;
            this.soPic = soPic;
            this.tongThoigian = baseTime;
        }
        public int[,] Matrix
        {
            get { return matranHien; }
            set { matranHien = value; }
        }
        public int SoPic
        {
            get { return soPic; }
            set { soPic = value; }
        }
        public long TongThoigian
        {
            get { return tongThoigian; }
            set { tongThoigian = value; }
        }

        private static LevelData level1 = new LevelData(MaTranGoc.Instance.TaoMatranGoc(8, 12), 20, 400);
        public static LevelData Level1
        {
            get { return level1; }
        }
        private static LevelData level2 = new LevelData(MaTranGoc.Instance.TaoMatranGoc(8, 12), 24, 500);
        public static LevelData Level2
        {
            get { return level2; }
        }
        private static LevelData level3 = new LevelData(MaTranGoc.Instance.TaoMatranGoc(8, 12), 24, 250);
        public static LevelData Level3
        {
            get { return level3; }
        }

        private static LevelData _instance;
        public static LevelData Instance
        {
            get
            {
                switch (Player.Instance.Capdo())
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
                        _instance = new LevelData(MaTranGoc.Instance.TaoMatranGoc(8, 12), 24, 400);
                        break;
                }
                return _instance;
            }
        }
    }
}
