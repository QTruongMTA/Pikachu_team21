using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class MatrixGenerator
    {
        private static MatrixGenerator _instance;
        public static MatrixGenerator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MatrixGenerator();
                }
                return _instance;
            }
        }

        private int[,] baseMatrix;
        public int[,] CreateDisplayMatrix(int rows, int cols)
        {
            baseMatrix = new int[rows+2, cols+2];
            return baseMatrix;
        }
    }
}
