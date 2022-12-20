using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGameDiffusionWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Diffusion> balls = new List<Diffusion>();
        private Pen delimiterColor = new Pen(Color.Black, 1);
        private int redGasPressure = 0;
        private int blueGasPressure = 0;
        private bool showPressure = false;
        private int numberBalls = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CreateGraphics().DrawLine(delimiterColor, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);

            var leftSideRed = 0;
            var leftSideBlue = 0;
            var center = 0;

            foreach (var ball in balls)
            {
                var side = ball.CheckSide();

                if (side == "left")
                {
                    if (ball.GetColor() == Color.Red)
                    {
                        leftSideRed++;
                        continue;
                    }

                    if (ball.GetColor() == Color.Blue)
                    {
                        leftSideBlue++;
                        continue;
                    }
                }

                if (side == "center")
                {
                    center++;
                }
            }

            if (leftSideRed == numberBalls / 2 && leftSideBlue == numberBalls / 2 && center == 0)
            {
                timer1.Stop();
                StopStartBalls();

                var message = $"Диффузия завершена!\r\nСуммарное давление на стенки сосуда красного газа: {redGasPressure}\r\nСуммарное давление на стенки сосуда синего газа: {blueGasPressure}";

                ShowPressure(message);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            StopStartBalls();

            var message = $"Пауза!\r\nСуммарное давление на стенки сосуда красного газа: {redGasPressure}\r\nСуммарное давление на стенки сосуда синего газа: {blueGasPressure}";

            ShowPressure(message);
        }

        private void ShowPressure(string message)
        {
            if (showPressure)
            {
                MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                showPressure = false;
                return;
            }

            showPressure = true;
        }

        private void StopStartBalls()
        {
            foreach (var ball in balls)
            {
                if (ball.IsMovable())
                {
                    ball.Stop();
                    continue;
                }

                ball.Start();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < numberBalls; i++)
            {
                var ball = new Diffusion(this, Color.Red);
                ball.Show();
                ball.OnHited += Ball_OnHited;
                balls.Add(ball);

                ball = new Diffusion(this, Color.Blue);
                ball.Show();
                ball.OnHited += Ball_OnHited;
                balls.Add(ball);
            }
        }

        private void Ball_OnHited(object? sender, HitEventArgs e)
        {
            if (e.Gas == Gas.Red)
            {
                redGasPressure++;

                switch (e.Side)
                {
                    case Bump.Left:
                        redGasLeftSideLabel.Text = (Convert.ToInt32(redGasLeftSideLabel.Text) + 1).ToString();
                        break;
                    case Bump.Right:
                        redGasRightSideLabel.Text = (Convert.ToInt32(redGasRightSideLabel.Text) + 1).ToString();
                        break;
                    case Bump.Top:
                        redGasTopSideLabel.Text = (Convert.ToInt32(redGasTopSideLabel.Text) + 1).ToString();
                        break;
                    case Bump.Bottom:
                        redGasBottomSideLabel.Text = (Convert.ToInt32(redGasBottomSideLabel.Text) + 1).ToString();
                        break;
                }
            }

            if (e.Gas == Gas.Blue)
            {
                blueGasPressure++;

                switch (e.Side)
                {
                    case Bump.Left:
                        blueGasLeftSideLabel.Text = (Convert.ToInt32(blueGasLeftSideLabel.Text) + 1).ToString();
                        break;
                    case Bump.Right:
                        blueGasRightSideLabel.Text = (Convert.ToInt32(blueGasRightSideLabel.Text) + 1).ToString();
                        break;
                    case Bump.Top:
                        blueGasTopSideLabel.Text = (Convert.ToInt32(blueGasTopSideLabel.Text) + 1).ToString();
                        break;
                    case Bump.Bottom:
                        blueGasBottomSideLabel.Text = (Convert.ToInt32(blueGasBottomSideLabel.Text) + 1).ToString();
                        break;
                }
            }
        }
    }
}