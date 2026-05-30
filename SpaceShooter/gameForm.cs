using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SpaceShooter
{
    public partial class gameForm : Form
    {
        //Player movement variables
        bool goLeft, goRight,goUp,goDown;
        int playerSpeed = 10;
        //Star variables
        List<Star> stars = new List<Star>();
        Random rand = new Random();
        //Enemy variables
        PictureBox[] enemies;
        Random random = new Random();
        //Bullet variables
        List<PictureBox> bullets = new List<PictureBox>();
        int bulletCounter = 0;
        int score = 0;

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            
            
        }

        private void gameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
          
        }

        public gameForm()
        {
            InitializeComponent();

            int[] lanes = { 20, 110, 200, 290, 380, 470, 560, 650, 740, 830, 920, 1010 };

            enemies = new PictureBox[] {
                enemyBlue1,
                enemyBlue2,
                enemyBlue3,
                //enemyBlue4,
                enemyGreen1, 
                enemyGreen2,
                enemyGreen3,
                //enemyGreen4,
                enemyPink1,
                enemyPink2,
                enemyPink3,
                //enemyPink4,
                enemyYellow1,
                enemyYellow2,
                enemyYellow3,
                //enemyYellow4
            };
            player.BringToFront();


            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Left = lanes[i % lanes.Length];
                enemies[i].Top = -(i * 120);
            }

            foreach (PictureBox enemy in enemies)
            {
                enemy.Left = random.Next(0, this.ClientSize.Width - enemy.Width);
                enemy.Top = random.Next(-500, -50);
            }
            //Key events
            this.KeyDown += gameForm_KeyDown;
            this.KeyUp += gameForm_KeyUp;

            this.DoubleBuffered = true;
            //Create stars
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
            //Start the game timer
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Start();
        }
        private void ShootBullet()
        {
            SoundPlayer shootSound = new SoundPlayer(Properties.Resources.shooting); 
            shootSound.Play();
            PictureBox leftBullet = new PictureBox();

            leftBullet.Width = 8;
            leftBullet.Height = 15;
            leftBullet.BackColor = Color.Yellow;

            leftBullet.Left = player.Left + 10;
            leftBullet.Top = player.Top;

            this.Controls.Add(leftBullet);
            leftBullet.BringToFront();

            bullets.Add(leftBullet);

            PictureBox rightBullet = new PictureBox();

            rightBullet.Width = 8;
            rightBullet.Height = 15;
            rightBullet.BackColor = Color.Yellow;

            rightBullet.Left = player.Right - 18;
            rightBullet.Top = player.Top;

            this.Controls.Add(rightBullet);
            rightBullet.BringToFront();

            bullets.Add(rightBullet);
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lblScore.BringToFront();
            lblScoreCounter.BringToFront();
            // Automatic shooting
            bulletCounter++;

            if (bulletCounter >= 12)
            {
                ShootBullet();
                bulletCounter = 0;
            }

            // Move bullets and check collision
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i].Top -= 35;

                bool bulletHit = false;

                foreach (PictureBox enemy in enemies)
                {
                    if (bullets[i].Bounds.IntersectsWith(enemy.Bounds))
                    {
                        // Increase score
                        score += 5;
                        lblScoreCounter.Text = score.ToString();

                        // Respawn enemy
                        enemy.Left = random.Next(0, this.ClientSize.Width - enemy.Width);
                        enemy.Top = random.Next(-200, -50);

                        // Remove bullet
                        this.Controls.Remove(bullets[i]);
                        bullets.RemoveAt(i);

                        bulletHit = true;
                        break;
                    }
                }

                if (bulletHit)
                    continue;

                // Remove bullet if it leaves screen
                if (bullets[i].Top < -20)
                {
                    this.Controls.Remove(bullets[i]);
                    bullets.RemoveAt(i);
                }
            }

            // Move stars
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

            // Move enemies
            foreach (PictureBox enemy in enemies)
            {
                enemy.Top += 3;

                if (enemy.Top > this.ClientSize.Height)
                {
                    enemy.Left = random.Next(0, this.ClientSize.Width - enemy.Width);
                    enemy.Top = random.Next(-200, -50);
                }
            }
            // Check for collision with player
            foreach (PictureBox enemy in enemies)
            {
                if (player.Bounds.IntersectsWith(enemy.Bounds))
                {
                    GameOver();
                    return;
                }
            }

            // Move player
            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight && player.Left + player.Width < ClientSize.Width)
            {
                player.Left += playerSpeed;
            }
        }
        private void GameOver()
        {
            gameTimer.Stop();

            SoundPlayer gameoversound = new SoundPlayer(Properties.Resources.gameover);
            gameoversound.Play();
            gameoverForm gameover = new gameoverForm();
            gameover.finalScore = score; // Pass the final score to the gameover form
            gameover.Show();

            this.Hide();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            //Draw the stars
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


    }
}
