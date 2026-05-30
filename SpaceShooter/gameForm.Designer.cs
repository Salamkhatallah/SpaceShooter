namespace SpaceShooter
{
    partial class gameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreCounter = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.enemyBlue1 = new System.Windows.Forms.PictureBox();
            this.enemyPink1 = new System.Windows.Forms.PictureBox();
            this.enemyYellow1 = new System.Windows.Forms.PictureBox();
            this.enemyGreen1 = new System.Windows.Forms.PictureBox();
            this.enemyYellow3 = new System.Windows.Forms.PictureBox();
            this.enemyYellow2 = new System.Windows.Forms.PictureBox();
            this.enemyPink3 = new System.Windows.Forms.PictureBox();
            this.enemyPink2 = new System.Windows.Forms.PictureBox();
            this.enemyGreen2 = new System.Windows.Forms.PictureBox();
            this.enemyGreen3 = new System.Windows.Forms.PictureBox();
            this.enemyBlue3 = new System.Windows.Forms.PictureBox();
            this.enemyBlue2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBlue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyYellow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyYellow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyYellow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGreen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGreen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBlue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBlue2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScore.Location = new System.Drawing.Point(21, 22);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(133, 37);
            this.lblScore.TabIndex = 50;
            this.lblScore.Text = "Score :";
            // 
            // lblScoreCounter
            // 
            this.lblScoreCounter.AutoSize = true;
            this.lblScoreCounter.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCounter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScoreCounter.Location = new System.Drawing.Point(160, 25);
            this.lblScoreCounter.Name = "lblScoreCounter";
            this.lblScoreCounter.Size = new System.Drawing.Size(49, 35);
            this.lblScoreCounter.TabIndex = 51;
            this.lblScoreCounter.Text = "00";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::SpaceShooter.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(442, 503);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(200, 200);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // enemyBlue1
            // 
            this.enemyBlue1.BackColor = System.Drawing.Color.Transparent;
            this.enemyBlue1.Image = global::SpaceShooter.Properties.Resources.enemyBlue;
            this.enemyBlue1.Location = new System.Drawing.Point(136, 152);
            this.enemyBlue1.Name = "enemyBlue1";
            this.enemyBlue1.Size = new System.Drawing.Size(95, 70);
            this.enemyBlue1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyBlue1.TabIndex = 3;
            this.enemyBlue1.TabStop = false;
            // 
            // enemyPink1
            // 
            this.enemyPink1.BackColor = System.Drawing.Color.Transparent;
            this.enemyPink1.Image = global::SpaceShooter.Properties.Resources.enemyPink;
            this.enemyPink1.Location = new System.Drawing.Point(442, 152);
            this.enemyPink1.Name = "enemyPink1";
            this.enemyPink1.Size = new System.Drawing.Size(95, 70);
            this.enemyPink1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPink1.TabIndex = 4;
            this.enemyPink1.TabStop = false;
            // 
            // enemyYellow1
            // 
            this.enemyYellow1.BackColor = System.Drawing.Color.Transparent;
            this.enemyYellow1.Image = global::SpaceShooter.Properties.Resources.enemyYellow;
            this.enemyYellow1.Location = new System.Drawing.Point(580, 138);
            this.enemyYellow1.Name = "enemyYellow1";
            this.enemyYellow1.Size = new System.Drawing.Size(105, 75);
            this.enemyYellow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyYellow1.TabIndex = 5;
            this.enemyYellow1.TabStop = false;
            // 
            // enemyGreen1
            // 
            this.enemyGreen1.BackColor = System.Drawing.Color.Transparent;
            this.enemyGreen1.Image = global::SpaceShooter.Properties.Resources.enemyGreen;
            this.enemyGreen1.Location = new System.Drawing.Point(289, 152);
            this.enemyGreen1.Name = "enemyGreen1";
            this.enemyGreen1.Size = new System.Drawing.Size(95, 70);
            this.enemyGreen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyGreen1.TabIndex = 6;
            this.enemyGreen1.TabStop = false;
            // 
            // enemyYellow3
            // 
            this.enemyYellow3.BackColor = System.Drawing.Color.Transparent;
            this.enemyYellow3.Image = global::SpaceShooter.Properties.Resources.enemyYellow;
            this.enemyYellow3.Location = new System.Drawing.Point(505, 320);
            this.enemyYellow3.Name = "enemyYellow3";
            this.enemyYellow3.Size = new System.Drawing.Size(105, 75);
            this.enemyYellow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyYellow3.TabIndex = 7;
            this.enemyYellow3.TabStop = false;
            // 
            // enemyYellow2
            // 
            this.enemyYellow2.BackColor = System.Drawing.Color.Transparent;
            this.enemyYellow2.Image = global::SpaceShooter.Properties.Resources.enemyYellow;
            this.enemyYellow2.Location = new System.Drawing.Point(833, 230);
            this.enemyYellow2.Name = "enemyYellow2";
            this.enemyYellow2.Size = new System.Drawing.Size(105, 75);
            this.enemyYellow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyYellow2.TabIndex = 9;
            this.enemyYellow2.TabStop = false;
            // 
            // enemyPink3
            // 
            this.enemyPink3.BackColor = System.Drawing.Color.Transparent;
            this.enemyPink3.Image = global::SpaceShooter.Properties.Resources.enemyPink;
            this.enemyPink3.Location = new System.Drawing.Point(350, 320);
            this.enemyPink3.Name = "enemyPink3";
            this.enemyPink3.Size = new System.Drawing.Size(95, 70);
            this.enemyPink3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPink3.TabIndex = 10;
            this.enemyPink3.TabStop = false;
            // 
            // enemyPink2
            // 
            this.enemyPink2.BackColor = System.Drawing.Color.Transparent;
            this.enemyPink2.Image = global::SpaceShooter.Properties.Resources.enemyPink;
            this.enemyPink2.Location = new System.Drawing.Point(151, 320);
            this.enemyPink2.Name = "enemyPink2";
            this.enemyPink2.Size = new System.Drawing.Size(95, 70);
            this.enemyPink2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPink2.TabIndex = 12;
            this.enemyPink2.TabStop = false;
            // 
            // enemyGreen2
            // 
            this.enemyGreen2.BackColor = System.Drawing.Color.Transparent;
            this.enemyGreen2.Image = global::SpaceShooter.Properties.Resources.enemyGreen;
            this.enemyGreen2.Location = new System.Drawing.Point(394, 61);
            this.enemyGreen2.Name = "enemyGreen2";
            this.enemyGreen2.Size = new System.Drawing.Size(95, 70);
            this.enemyGreen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyGreen2.TabIndex = 13;
            this.enemyGreen2.TabStop = false;
            // 
            // enemyGreen3
            // 
            this.enemyGreen3.BackColor = System.Drawing.Color.Transparent;
            this.enemyGreen3.Image = global::SpaceShooter.Properties.Resources.enemyGreen;
            this.enemyGreen3.Location = new System.Drawing.Point(821, 61);
            this.enemyGreen3.Name = "enemyGreen3";
            this.enemyGreen3.Size = new System.Drawing.Size(95, 70);
            this.enemyGreen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyGreen3.TabIndex = 14;
            this.enemyGreen3.TabStop = false;
            // 
            // enemyBlue3
            // 
            this.enemyBlue3.BackColor = System.Drawing.Color.Transparent;
            this.enemyBlue3.Image = global::SpaceShooter.Properties.Resources.enemyBlue;
            this.enemyBlue3.Location = new System.Drawing.Point(876, 152);
            this.enemyBlue3.Name = "enemyBlue3";
            this.enemyBlue3.Size = new System.Drawing.Size(95, 70);
            this.enemyBlue3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyBlue3.TabIndex = 16;
            this.enemyBlue3.TabStop = false;
            // 
            // enemyBlue2
            // 
            this.enemyBlue2.BackColor = System.Drawing.Color.Transparent;
            this.enemyBlue2.Image = global::SpaceShooter.Properties.Resources.enemyBlue;
            this.enemyBlue2.Location = new System.Drawing.Point(532, 51);
            this.enemyBlue2.Name = "enemyBlue2";
            this.enemyBlue2.Size = new System.Drawing.Size(95, 70);
            this.enemyBlue2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyBlue2.TabIndex = 18;
            this.enemyBlue2.TabStop = false;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1115, 715);
            this.ControlBox = false;
            this.Controls.Add(this.enemyBlue2);
            this.Controls.Add(this.enemyBlue3);
            this.Controls.Add(this.enemyGreen3);
            this.Controls.Add(this.enemyGreen2);
            this.Controls.Add(this.enemyPink2);
            this.Controls.Add(this.enemyPink3);
            this.Controls.Add(this.enemyYellow2);
            this.Controls.Add(this.enemyYellow3);
            this.Controls.Add(this.enemyGreen1);
            this.Controls.Add(this.enemyYellow1);
            this.Controls.Add(this.enemyPink1);
            this.Controls.Add(this.enemyBlue1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lblScoreCounter);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "gameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBlue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyYellow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyYellow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyYellow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGreen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyGreen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBlue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBlue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreCounter;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemyBlue1;
        private System.Windows.Forms.PictureBox enemyPink1;
        private System.Windows.Forms.PictureBox enemyYellow1;
        private System.Windows.Forms.PictureBox enemyGreen1;
        private System.Windows.Forms.PictureBox enemyYellow3;
        private System.Windows.Forms.PictureBox enemyYellow2;
        private System.Windows.Forms.PictureBox enemyPink3;
        private System.Windows.Forms.PictureBox enemyPink2;
        private System.Windows.Forms.PictureBox enemyGreen2;
        private System.Windows.Forms.PictureBox enemyGreen3;
        private System.Windows.Forms.PictureBox enemyBlue3;
        private System.Windows.Forms.PictureBox enemyBlue2;
    }
}