using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSnake
{
    public partial class frmSnake : Form
    {
        Spiel sp;
        Gitter git;
        Update up;
        int intKastenX;
        int intKastenY;
        int intBoxSize = 15;
        int intTmerCounter;
        int intRichtung;
        int intAnfangX=16;
        int intAnfangY=15;
        int intEndeX;
        int intEndeY;
        int intX, intY;

        public frmSnake()
        {
            InitializeComponent();
            sp = new Spiel();
            git = new Gitter();
            up = new Update();
            pbSpielfeld.BackColor = Color.White;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            timerTick.Enabled = true;
            
            git.Linien(pbSpielfeld);

        }

        private void pbSpielfeld_Click(object sender, EventArgs e)
        {

            sp.EssenGenerieren(pbSpielfeld, Brushes.Green, intBoxSize);
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            
            if (intRichtung == 1) //Links
            {
                git.Linien(pbSpielfeld);
                up.UpdateAll(pbSpielfeld);
                git.Linien(pbSpielfeld);
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX--, intY, intBoxSize);

            }
            else if (intRichtung == 2) //Rechts
            {
                git.Linien(pbSpielfeld);
                up.UpdateAll(pbSpielfeld);
                git.Linien(pbSpielfeld);
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX++, intY, intBoxSize);
            }
            else if (intRichtung == 3) //Hoch
            {
                git.Linien(pbSpielfeld);
                up.UpdateAll(pbSpielfeld);
                git.Linien(pbSpielfeld);
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX, intY --, intBoxSize);
            }
            else if (intRichtung == 4) //Runter
            {
                git.Linien(pbSpielfeld);
                up.UpdateAll(pbSpielfeld);
                git.Linien(pbSpielfeld);
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX, intY ++, intBoxSize);
            }
            else
            {
                git.Linien(pbSpielfeld);
                up.UpdateAll(pbSpielfeld);
                git.Linien(pbSpielfeld);
                sp.Schlange(pbSpielfeld, Brushes.Pink, intAnfangX, intAnfangY, intBoxSize);
                intX = intAnfangX;
                intY = intAnfangY;
            } 
            intTmerCounter++;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Up && intRichtung != 4)
            {
                intRichtung = 3;
                return true;
            }
            else if (keyData == Keys.Down && intRichtung != 3)
            {
                intRichtung = 4;
                return true;
            }
            else if (keyData == Keys.Left && intRichtung != 2)
            {
                intRichtung = 1;
                return true;
            }
            else if (keyData == Keys.Right && intRichtung != 1)
            {
                intRichtung = 2;
                return true;
            }


            return base.ProcessDialogKey(keyData);
        }

        /*private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    intRichtung = 1;
                    break;
                case Keys.Right:
                    intRichtung = 2;
                    break;
                case Keys.Up:
                    intRichtung = 3;
                    break;
                case Keys.Down:
                    intRichtung = 4;
                    break;
                default:
                    break;
            }*/
        }
    }
