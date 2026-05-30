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
    public partial class gameoverForm : Form
    {
        public int finalScore;
        List<Star> stars = new List<Star>();
        Random rand = new Random();
        public gameoverForm()
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

        private void gameoverForm_Load(object sender, EventArgs e)
        {
            lblFinalScore.Text = finalScore.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            gameForm gameForm = new gameForm();
            gameForm.Show();
            this.Close();
        }
    }
}
    