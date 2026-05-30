using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpaceShooter
{
    public partial class mainForm : Form
    {
        List<Star> stars = new List<Star>();
        Random rand = new Random();
        public mainForm()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            for (int i = 0; i < 100; i++)
            {
                stars.Add(new Star()
                { 
                    x = rand.Next(0, this.ClientSize.Width),
                    y = rand.Next(0, this.ClientSize.Height),
                    size = rand.Next(1, 4),
                    speed = rand.Next(2, 8)
        
                    });
            }

            gameTimer.Interval = 20; 
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Start();

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            foreach (Star star in stars)
            {
                star.y += star.speed;
                if (star.y > ClientSize.Height)
                {
                    star.y = 0;
                    star.x = rand.Next(0, ClientSize.Width);


                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Star star in stars)
            {
                e.Graphics.FillEllipse(
                    Brushes.White,
                    star.x,
                    star.y,
                    star.size,
                    star.size);
            }
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the arrow keys to move the plane and spacebar to shoot. Avoid enemy fire and destroy as many enemies as possible to achieve a high score!", "Game Instructions",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameForm game = new gameForm();
            game.Show();
            this.Hide();
        }
    }
}
