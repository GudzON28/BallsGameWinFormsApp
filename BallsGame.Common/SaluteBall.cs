using System.Drawing;
using System.Windows.Forms;

namespace BallsGame.Common
{
    public class SaluteBall : MoveBall
    {
        private float g = 0.2f;

        public SaluteBall(Form form, int centerX, int centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            vY = random.Next(-10, 5);
            vX = random.Next(-7, 8);
            radius = random.Next(2, 10);
            color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        protected override void Go()
        {
            base.Go();
            vY += g;
            color = Color.FromArgb(random.Next(75, 256), color.R, color.G, color.B);
        }
    }
}
