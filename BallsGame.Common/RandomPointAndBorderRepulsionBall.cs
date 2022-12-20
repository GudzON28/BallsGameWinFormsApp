using System;
using System.Windows.Forms;

namespace BallsGame.Common
{
    public class RandomPointAndBorderRepulsionBall : MoveBall
    {
        public RandomPointAndBorderRepulsionBall(Form form) : base(form)
        {
            radius = 30;
        }

        protected override void Timer_Tick(object sender, EventArgs e)
        {
            base.Timer_Tick(sender, e);
            CheckPosition();
        }

        protected virtual void CheckPosition()
        {
            if (centerX > RightSide() || centerX < LeftSide())
            {
                vX = -vX;
            }

            if (centerY > BottomSide() || centerY < TopSide())
            {
                vY = -vY;
            }
        }
    }
}