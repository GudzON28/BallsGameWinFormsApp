using BallsGame.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGameAutomaticSaluteWinFormsApp
{
    public class AutomaticSaluteBall : MoveBall
    {
        private int bangPoint;

        public AutomaticSaluteBall(Form form) : base(form)
        {
            color = Color.FromArgb(75, 75, 75);
            centerY = form.ClientSize.Height;
            vY = random.Next(-9, -6);
            radius = 20;
            bangPoint = random.Next(form.ClientSize.Height);
        }

        protected override void Timer_Tick(object sender, EventArgs e)
        {
            base.Timer_Tick(sender, e);

            if (centerY < bangPoint)
            {
                Clear();
                Stop();
                Bang();
            }
        }

        private void Bang()
        {
            var count = random.Next(15, 50);

            for (int i = 0; i < count; i++)
            {
                var salute = new SaluteBall(form, (int)centerX, (int)centerY);
                salute.Start();
            }
        }
    }
}
