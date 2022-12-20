using BallsGame.Common;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGameFruitNinjaWinFormsApp
{
    public class FruitNinjaBall : MoveBall
    {
        private float g = 0.2f;
        private int bananaFactorSpeed = 10;

        public FruitNinjaBall(Form form, bool bananaBonusEnabled) : base(form)
        {
            timer.Interval = random.Next(3, 7);

            if (bananaBonusEnabled)
            {
                timer.Interval *= bananaFactorSpeed;
            }

            centerY = form.ClientSize.Height - (radius + 1);
            vY = random.Next(-20, -14);
            centerX = random.Next(form.ClientSize.Width / 2 - form.ClientSize.Width / 4, form.ClientSize.Width / 2 + form.ClientSize.Width / 4);

            if (GenerateBomb())
            {
                color = Color.Black;
            }

            if (GenerateBanana())
            {
                color = Color.Yellow;
            }
        }

        public override bool OnField()
        {
            return centerY < BottomSide();
        }

        public Color GetColor()
        {
            return color;
        }

        public void SetSpeed(bool bananaBonusActive)
        {
            if (bananaBonusActive)
            {
                timer.Interval *= bananaFactorSpeed;
                return;
            }

            timer.Interval /= bananaFactorSpeed;
        }

        protected override void Go()
        {
            base.Go();
            vY += g;
        }

        private bool GenerateBomb()
        {
            return random.Next(6) == 0;
        }

        private bool GenerateBanana()
        {
            return random.Next(6) == 0;
        }
    }
}