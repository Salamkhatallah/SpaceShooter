namespace SpaceShooter
{
    partial class gameoverForm
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
            this.player = new System.Windows.Forms.PictureBox();
            this.enemyPink = new System.Windows.Forms.PictureBox();
            this.lblGameover = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::SpaceShooter.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(423, 462);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(200, 200);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // enemyPink
            // 
            this.enemyPink.BackColor = System.Drawing.Color.Transparent;
            this.enemyPink.Image = global::SpaceShooter.Properties.Resources.enemyPink;
            this.enemyPink.Location = new System.Drawing.Point(479, 417);
            this.enemyPink.Name = "enemyPink";
            this.enemyPink.Size = new System.Drawing.Size(95, 70);
            this.enemyPink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPink.TabIndex = 5;
            this.enemyPink.TabStop = false;
            // 
            // lblGameover
            // 
            this.lblGameover.AutoSize = true;
            this.lblGameover.Font = new System.Drawing.Font("Showcard Gothic", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameover.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblGameover.Location = new System.Drawing.Point(269, 72);
            this.lblGameover.Name = "lblGameover";
            this.lblGameover.Size = new System.Drawing.Size(528, 111);
            this.lblGameover.TabIndex = 6;
            this.lblGameover.Text = "GAMEOVER";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Window;
            this.lblScore.Location = new System.Drawing.Point(414, 195);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(178, 54);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score:";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFinalScore.Location = new System.Drawing.Point(584, 195);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(77, 54);
            this.lblFinalScore.TabIndex = 8;
            this.lblFinalScore.Text = "00";
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Transparent;
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnRetry.FlatAppearance.BorderSize = 2;
            this.btnRetry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnRetry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnRetry.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.ForeColor = System.Drawing.Color.HotPink;
            this.btnRetry.Location = new System.Drawing.Point(153, 305);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(329, 69);
            this.btnRetry.TabIndex = 9;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnExit.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Lime;
            this.btnExit.Location = new System.Drawing.Point(593, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(329, 69);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gameoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1103, 674);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGameover);
            this.Controls.Add(this.enemyPink);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "gameoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.gameoverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox enemyPink;
        private System.Windows.Forms.Label lblGameover;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer gameTimer;
    }
}