using System;
using System.Windows.Forms;

namespace BallsGameAutomaticSaluteWinFormsApp
{
    public partial class MainForm : Form
    {
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            timer1.Interval = random.Next(500, 5001);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            var bigBall = new AutomaticSaluteBall(this);
            bigBall.Start();
            timer1.Interval = random.Next(500, 5001);
        }
    }
}