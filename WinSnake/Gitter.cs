using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinSnake
{
    class Gitter
    {
        Graphics g;


        public void Linien(PictureBox pb)
        {
            g = pb.CreateGraphics();
            for (int i = 0; i < 450; i = i + 15)
            {
                g.DrawLine(Pens.LightGray, 0, i, 450, i);
                g.DrawLine(Pens.LightGray, i, 0, i, 450);
            }
            g.DrawLine(Pens.LightGray, 0, 449, 449, 449);
            g.DrawLine(Pens.LightGray, 449, 0, 449, 449);
        }

    }
}
