using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class MaTranGoc
    {
        private static MaTranGoc _instance;
        public static MaTranGoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MaTranGoc();
                }
                return _instance;
            }
        }

        private int[,] matranGoc;
        public int[,] TaoMatranGoc(int rows, int cols)
        {
            matranGoc = new int[rows+2, cols+2];
            return matranGoc;
        }
    }
}
