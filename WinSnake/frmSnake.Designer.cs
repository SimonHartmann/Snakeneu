namespace WinSnake
{
    partial class frmSnake
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbSpielfeld = new System.Windows.Forms.PictureBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpielfeld)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSpielfeld
            // 
            this.pbSpielfeld.Location = new System.Drawing.Point(0, 0);
            this.pbSpielfeld.Name = "pbSpielfeld";
            this.pbSpielfeld.Size = new System.Drawing.Size(450, 450);
            this.pbSpielfeld.TabIndex = 0;
            this.pbSpielfeld.TabStop = false;
            this.pbSpielfeld.Click += new System.EventHandler(this.pbSpielfeld_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(456, 387);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(456, 416);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(75, 23);
            this.cmdReset.TabIndex = 2;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            // 
            // timerTick
            // 
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.Location = new System.Drawing.Point(473, 22);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(38, 13);
            this.lblTextScore.TabIndex = 3;
            this.lblTextScore.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(473, 76);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 4;
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 478);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.pbSpielfeld);
            this.Name = "frmSnake";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpielfeld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpielfeld;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.Label lblTextScore;
        private System.Windows.Forms.Label lblScore;
    }
}

