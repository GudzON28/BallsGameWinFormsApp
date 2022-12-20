using System;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp
{
    public class Barrier
    {
        protected Form form;
        private static Random random = new Random();
        private int pointX, pointY, width, height;
        private Graphics graphics;
        private Brush brush = new SolidBrush(Color.Gray);
        private bool destroyed = false;

        public Barrier(Form form)
        {
            this.form = form;
        }

        public void Draw()
        {
            graphics = form.CreateGraphics();
            pointX = random.Next(form.ClientSize.Width / 4, form.ClientSize.Width - form.ClientSize.Width / 4);
            pointY = random.Next(form.ClientSize.Height / 4, form.ClientSize.Height - form.ClientSize.Height / 4);
            width = random.Next(10, 21);
            height = random.Next(50, 101);
            destroyed = false;

            graphics.FillRectangle(brush, new Rectangle(pointX, pointY, width, height));
        }

        public int GetX()
        {
            return pointX;
        }

        public int GetY()
        {
            return pointY;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public bool IsDestroyed()
        {
            return destroyed;
        }

        public void Clear()
        {
            brush = new SolidBrush(form.BackColor);
            graphics.FillRectangle(brush, new Rectangle(pointX, pointY, width, height));
            destroyed = true;
        }
    }
}