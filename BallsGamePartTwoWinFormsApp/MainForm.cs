using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallsGame.Common;

namespace BallsGamePartTwoWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> moveBalls = new List<MoveBall>();
        private int numCatchBalls = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < moveBalls.Count; i++)
            {
                if (moveBalls[i].Catch(e.X, e.Y))
                {
                    if (moveBalls[i].OnField())
                    {
                        numCatchBalls++;
                        catchBallsLabel.Text = numCatchBalls.ToString();
                    }

                    moveBalls[i].Stop();
                    moveBalls[i].Clear();
                    moveBalls.RemoveAt(i);
                    return;
                }
            }
        }
    }
}