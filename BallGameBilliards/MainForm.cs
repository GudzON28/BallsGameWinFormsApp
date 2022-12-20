using BallsGame.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGameBilliards
{
    public partial class MainForm : Form
    {
        private List<Ball> moveBalls = new List<Ball>();

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void addBallButton_Click(object sender, EventArgs e)
        {
            var moveBall = new RandomPointAndBorderRepulsionBall(this);
            moveBalls.Add(moveBall);
            moveBall.Start();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            var indentFromBorder = 12;
            var verticalIndent = indentFromBorder;
            var horizontalIndent = ActiveForm.ClientSize.Width - (indentFromBorder + addBallButton.Width);

            addBallButton.Location = new System.Drawing.Point(horizontalIndent, verticalIndent);
        }
    }
}