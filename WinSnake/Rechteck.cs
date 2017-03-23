using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSnake
{
    class Rechteck
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Rechteck(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Rechteck()
        {
            X = 0;
            Y = 0;
        }
    }
}
