using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallsGame.Common;

namespace BallsGameWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls = new List<MoveBall>();
        private int numBalls = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void createBallsButton_Click(object sender, EventArgs e)
        {
            numBalls = 0;

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }

            stopBallsButton.Enabled = true;
        }

        private void stopBallsButton_Click(object sender, EventArgs e)
        {

            foreach (var ball in moveBalls)
            {
                ball.Stop();

                if (ball.OnField())
                {
                    numBalls++;
                }
            }

            ShowResults();
            DeleteAllBalls();

            stopBallsButton.Enabled = false;
        }

        private void ShowResults()
        {
            MessageBox.Show($"Вы успели поймать {numBalls} шарик!");
        }

        private void DeleteAllBalls()
        {
            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }

            moveBalls.Clear();
        }
    }
}