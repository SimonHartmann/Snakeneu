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
        Random rnd = new Random(DateTime.Now.Millisecond);
        Graphics g;
        public int intEssenY { get; set; }
        public int intEssenX { get; set; }
        public List<Rechteck> snakelist { get; set; }
        
        
        public void UpdateAll(PictureBox pb,int intx, int inty, int intboxsize)
        {
            g = pb.CreateGraphics();
            g.FillRectangle(Brushes.White,0,0,450,450);

            for (int i = 0; i < snakelist.Count; i++)
            {
                //Schlange
                g.FillRectangle(Brushes.Pink,snakelist[i].X=intx * intboxsize, snakelist[i].Y = inty * intboxsize, intboxsize, intboxsize);
            } 
            
            //Essen
            g.FillRectangle(Brushes.Peru,intEssenX * intboxsize,intEssenY * intboxsize, intboxsize, intboxsize);

        }
        
        public void Schlange(PictureBox pb,int intx, int inty, int intboxsize, int intschlangenlaenge)
        {
            g = pb.CreateGraphics();
            g.FillRectangle(Brushes.Pink, intx *intboxsize, inty*intboxsize , intboxsize, intboxsize);
        }
       
        public void UpdateEssen(PictureBox pb, int intboxsize)
        {
            g = pb.CreateGraphics();
            intEssenX = rnd.Next(0, 30);
            intEssenY = rnd.Next(0, 30);
            g.FillRectangle(Brushes.Peru, intEssenX * intboxsize, intEssenY * intboxsize, intboxsize, intboxsize);

        }

       
    }
}
