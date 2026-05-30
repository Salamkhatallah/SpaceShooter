namespace SpaceShooter
{
    partial class mainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(172, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(731, 111);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SPACESHOOTER";
            // 
            // btninfo
            // 
            this.btninfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btninfo.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btninfo.Location = new System.Drawing.Point(1063, 12);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(40, 40);
            this.btninfo.TabIndex = 1;
            this.btninfo.Text = "?";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnStart.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.HotPink;
            this.btnStart.Location = new System.Drawing.Point(379, 503);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(329, 69);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.Image = global::SpaceShooter.Properties.Resources.player;
            this.pictureBoxPlane.Location = new System.Drawing.Point(379, 169);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlane.TabIndex = 3;
            this.pictureBoxPlane.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1115, 715);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxPlane);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Timer gameTimer;
    }
}

