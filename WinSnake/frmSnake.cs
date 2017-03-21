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
        
        Update up;
        int intBoxSize = 15;
        int intAnfangX = 16;
        int intAnfangY = 15;
        int intSchlangeLaenge = 1;
        int intTmerCounter;
        int intRichtung;
        int intX, intY;
        int score=0;

        public frmSnake()
        {
            InitializeComponent();
            up = new Update();
            pbSpielfeld.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            timerTick.Enabled = true;
            up.UpdateEssen(pbSpielfeld,intBoxSize);
            lblScore.Text = Convert.ToString(score);
            cmdStart.Enabled = false;
        }

        private void pbSpielfeld_Click(object sender, EventArgs e)
        {
            
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            
            if (intRichtung == 1)       //Links
            {
                up.UpdateAll(pbSpielfeld,intX,intY,intBoxSize);
                up.Schlange(pbSpielfeld, intX--, intY, intBoxSize,intSchlangeLaenge);
            }
            else if (intRichtung == 2) //Rechts
            {
                up.UpdateAll(pbSpielfeld, intX, intY, intBoxSize);
                up.Schlange(pbSpielfeld, intX++, intY, intBoxSize,intSchlangeLaenge);
            }
            else if (intRichtung == 3) //Hoch
            {
                up.UpdateAll(pbSpielfeld, intX, intY, intBoxSize);
                up.Schlange(pbSpielfeld, intX, intY --, intBoxSize,intSchlangeLaenge);
            }
            else if (intRichtung == 4) //Runter
            {
                up.UpdateAll(pbSpielfeld, intX, intY, intBoxSize);
                up.Schlange(pbSpielfeld, intX, intY ++, intBoxSize,intSchlangeLaenge);
            }
            else
            {
                up.UpdateAll(pbSpielfeld, intX, intY, intBoxSize);
                intX = intAnfangX;
                intY = intAnfangY;
            } 

            if(up.intEssenX==intX && up.intEssenY == intY) //Schlange isst Essen
            {
                score = score + 100;
                lblScore.Text = Convert.ToString(score);
                intSchlangeLaenge++;
                up.UpdateEssen(pbSpielfeld, intBoxSize);
            }

            if (intX < 0 || intX > 30 || intY < 0 || intY > 30)
            {
                timerTick.Enabled = false;
                pbSpielfeld.Enabled = false;
                MessageBox.Show("Sie haben verloren!");
                
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

       
        }
    }
