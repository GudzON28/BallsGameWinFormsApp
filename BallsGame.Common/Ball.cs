using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsGame.Common
{
    public class Ball
    {
        protected Form form;
        protected Color color = Color.Red;
        protected float vX = 2;
        protected float vY = 2;
        protected float centerX = 0;
        protected float centerY = 0;
        protected int radius = 40;
        protected static Random random = new Random();
        protected Timer timer;
        private SolidBrush brush = new SolidBrush(Color.Black);

        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = random.Next(5, 20);
            timer.Tick += Timer_Tick;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public virtual bool OnField()
        {
            return centerX > LeftSide() && centerX < RightSide() && centerY > TopSide() && centerY < BottomSide();
        }

        public bool Catch(int mouseClickX, int mouseClickY)
        {
            return Math.Pow(mouseClickY - centerY, 2) + Math.Pow(mouseClickX - centerX, 2) <= Math.Pow(radius, 2);
        }

        public void Clear()
        {
            Draw(form.BackColor);
        }

        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public void Show()
        {
            Draw(color);
        }

        protected virtual void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        protected void Move()
        {
            Clear();
            Go();
            Show();
        }

        protected int LeftSide()
        {
            return radius;
        }

        protected int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        protected int TopSide()
        {
            return radius;
        }

        protected int BottomSide()
        {
            return form.ClientSize.Height - radius;
        }

        private void Draw(Color color)
        {
            var graphics = form.CreateGraphics();
            brush.Color = color;
            var rectangle = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }

        protected virtual void Go()
        {
            centerX += vX;
            centerY += vY;
        }
    }
}