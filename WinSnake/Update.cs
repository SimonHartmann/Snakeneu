using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WinSnake
{
    class Update
    {
        Graphics g;
        public void UpdateAll(PictureBox pb)
        {
            g = pb.CreateGraphics();
            g.FillRectangle(Brushes.White,0,0,450,450);

        }


    }
}
