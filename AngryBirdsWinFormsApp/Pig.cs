using BallsGame.Common;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp
{
    public class Pig : RandomPointAndSizeBall
    {
        public Pig(Form form, PictureBox maximumRightClickZone, PictureBox maximumUpClickZone) : base(form)
        {
            radius = 25;
            vX = 0;
            vY = 0;
            color = Color.Green;

            if (centerX - radius < maximumRightClickZone.Location.X)
            {
                centerX = random.Next(LeftSide(), RightSide());
            }

            if (centerY + radius > maximumUpClickZone.Location.Y)
            {
                centerY = random.Next(TopSide(), BottomSide());
            }
        }

        public float GetCenterX()
        {
            return centerX;
        }

        public float GetCenterY()
        {
            return centerY;
        }

        public int GetRadius()
        {
            return radius;
        }
    }
}