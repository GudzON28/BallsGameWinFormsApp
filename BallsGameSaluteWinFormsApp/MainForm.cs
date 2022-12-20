using BallsGame.Common;
using System;
using System.Windows.Forms;

namespace BallsGameSaluteWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(3, 50);

            for (int i = 0; i < count; i++)
            {
                var salute = new SaluteBall(this, e.X, e.Y);
                salute.Start();
            }
        }
    }
}