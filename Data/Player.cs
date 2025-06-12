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

        private string name;

        private long score;

        private long time;

        private int numLevel;

        public string Name()
        {
            return Instance.name;
        }
        public long Score()
        {
            return Instance.score;
        }
        public long Time()
        {
            return Instance.time;
        }
        public int NumLevel()
        {
            return Instance.numLevel;
        }

        public void SetName(string name)
        {
            Instance.name = name;
        }
        public void SetScore(long score)
        {
            Instance.score = score;
        }
        public void  SetTime(long time)
        {
            Instance.time = time;
        }
        public void  SetNumLevel(int num)
        {
            Instance.numLevel = num;
        }

        internal void SavePlayer(object name, object score, object numLevel)
        {
            throw new NotImplementedException();
        }
    }
}
