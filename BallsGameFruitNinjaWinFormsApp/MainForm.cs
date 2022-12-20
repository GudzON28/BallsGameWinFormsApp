using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGameFruitNinjaWinFormsApp
{
    public partial class MainForm : Form
    {
        private Random random = new Random();
        private List<FruitNinjaBall> balls = new List<FruitNinjaBall>();
        private Timer bananaTimer = new Timer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bananaTimer.Enabled = false;
            bananaTimer.Interval = 5000;
            bananaTimer.Tick += BananaTimer_Tick;
        }

        private void BananaTimer_Tick(object? sender, EventArgs e)
        {
            bananaTimer.Stop();

            foreach (var ball in balls)
            {
                ball.SetSpeed(bananaTimer.Enabled);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ball = new FruitNinjaBall(this, bananaTimer.Enabled);
            ball.Start();
            balls.Add(ball);

            timer1.Interval = random.Next(500, 2001);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < balls.Count; i++)
            {
                if (!balls[i].OnField())
                {
                    balls[i].Stop();
                    balls[i].Clear();
                    balls.RemoveAt(i);
                    i--;
                    continue;
                }

                if (balls[i].Catch(e.X, e.Y))
                {
                    balls[i].Stop();

                    if (balls[i].GetColor() == Color.Black)
                    {
                        timer1.Stop();
                        StopBalls();
                        var newGame = MessageBox.Show("Вы задели бомбу!\r\nХотите начать новую игру?", "Конец игры!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        ClearBalls();
                        balls.Clear();

                        if (newGame == DialogResult.Yes)
                        {
                            scoreLabel.Text = "0";
                            timer1.Start();
                        }

                        break;
                    }

                    if (balls[i].GetColor() == Color.Yellow)
                    {
                        if (!bananaTimer.Enabled)
                        {
                            bananaTimer.Start();
                            SetSpeedVisibleBalls();
                        }
                    }

                    balls[i].Clear();
                    balls.RemoveAt(i);
                    i--;
                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
                }
            }
        }

        private void SetSpeedVisibleBalls()
        {
            foreach (var ball in balls)
            {
                ball.SetSpeed(bananaTimer.Enabled);
            }
        }

        private void ClearBalls()
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }
        }

        private void StopBalls()
        {
            foreach (var ball in balls)
            {
                ball.Stop();
            }
        }
    }
}