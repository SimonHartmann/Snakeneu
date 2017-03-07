using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinSnake
{
    class Zufall
    {
        Random rnd = new Random(DateTime.Now.Millisecond);

        public int intZufallFarbe;
        Brush farbe;


        public Zufall(int intMinimum, int intMaximum)
        {
            rnd.Next(intMinimum,intMaximum);
        }

        public void ZufallFarbe()
        {
            intZufallFarbe = rnd.Next(0, 10);
            switch (intZufallFarbe)
            {
                case 0:
                    
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
            }

        }

    }
}
