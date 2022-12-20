using BallsGame.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGameDiffusionWinFormsApp
{
    public class Diffusion : RandomPointAndBorderRepulsionBall
    {
        public event EventHandler<HitEventArgs> OnHited;

        public Diffusion(Form form, Color color) : base(form)
        {
            this.color = color;
            radius = 20;
            centerX = DropPositionX();
        }

        public Color GetColor()
        {
            return color;
        }

        protected override void Timer_Tick(object sender, EventArgs e)
        {
            base.Timer_Tick(sender, e);
        }

        protected override void CheckPosition()
        {
            if (centerX > RightSide())
            {
                vX = -vX;
                BumpEvent(Bump.Right);
            }

            if (centerX < LeftSide())
            {
                vX = -vX;
                BumpEvent(Bump.Left);
            }

            if (centerY > BottomSide())
            {
                vY = -vY;
                BumpEvent(Bump.Bottom);
            }

            if (centerY < TopSide())
            {
                vY = -vY;
                BumpEvent(Bump.Top);
            }
        }

        public string CheckSide()
        {
            if (centerX + radius < form.ClientSize.Width / 2)
            {
                return "left";
            }

            if (centerX - radius > form.ClientSize.Width / 2)
            {
                return "right";
            }

            return "center";
        }

        private int DropPositionX()
        {
            if (color == Color.Blue)
            {
                return random.Next(LeftSide(), form.ClientSize.Width / 2 - radius);
            }

            return random.Next(form.ClientSize.Width / 2 + LeftSide(), RightSide());
        }

        private void BumpEvent(Bump side)
        {
            if (color == Color.Blue)
            {
                OnHited.Invoke(this, new HitEventArgs(Gas.Blue, side));
            }

            if (color == Color.Red)
            {
                OnHited.Invoke(this, new HitEventArgs(Gas.Red, side));
            }
        }
    }
}