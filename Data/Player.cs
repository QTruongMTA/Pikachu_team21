using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class Player
    {
        private static Player _instance = new Player();
        public static Player Instance
        {
            get
            {
                return _instance;
            }
        }

        private string ten;

        private long diem;

        private long thoigian;

        private int capdo;

        public string Ten()
        {
            return Instance.ten;
        }
        public long Diem()
        {
            return Instance.diem;
        }
        public long Thoigian()
        {
            return Instance.thoigian;
        }
        public int Capdo()
        {
            return Instance.capdo;
        }

        public void SetTen(string ten)
        {
            Instance.ten = ten;
        }
        public void SetDiem(long diem)
        {
            Instance.diem = diem;
        }
        public void  SetThoigian(long thoigian)
        {
            Instance.thoigian = thoigian;
        }
        public void  SetCapdo(int capdo)
        {
            Instance.capdo = capdo;
        }
    }
}
