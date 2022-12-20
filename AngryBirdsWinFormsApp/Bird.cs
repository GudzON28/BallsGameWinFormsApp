using BallsGame.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp
{
    public class Bird : Ball
    {
        public event EventHandler OnEarth;
        public event EventHandler<PigEventArgs> OnPigTouched;
        public event EventHandler OnBarrierHited;
        public event EventHandler OnReturn;
        private float g = 0.2f;
        private int waitToRestart = 100;
        private Barrier barrier;
        private bool isTouched = false;
        private List<Pig> pigs = new List<Pig>();
        private BirdColor birdColor;
        private bool mainBird = true;
        private int blueAcceleration = 5;

        public Bird(Form form) : base(form)
        {
            RandomColor();
            BasePosition();
            timer.Interval = 10;
        }

        public Bird(Form form, Barrier barrier, Bird bird, string location) : base(form)
        {
            mainBird = false;
            this.barrier = barrier;
            color = bird.color;
            centerX = bird.centerX;
            centerY = bird.centerY;
            vX = bird.vX + blueAcceleration;
            radius = bird.radius;
            timer.Interval = 10;

            if (location == "lower")
            {
                vY = bird.vY - 2f;
            }
            else
            {
                vY = bird.vY + 2f;
            }
        }

        public void SlowMotion()
        {
            vY = -vY / 1.5f;
            vX /= 1.3f;
        }

        public void SavePigs(List<Pig> pigs)
        {
            this.pigs = pigs;
        }

        public void SetDirection(int clickX, int clickY)
        {
            var divider = 15f;
            vX = clickX / divider;
            vY = (form.ClientSize.Height - clickY) * -1 / divider;
        }

        public bool Restored()
        {
            return centerX == LeftSide() && centerY == BottomSide() - 1;
        }

        public void SaveBarrierPosition(Barrier barrier)
        {
            this.barrier = barrier;
        }

        public BirdColor GetColor()
        {
            return birdColor;
        }

        public void SetNewParameters()
        {
            switch (birdColor)
            {
                case BirdColor.Black:
                    radius *= 2;
                    vX /= 1.5f;
                    vY /= 1.5f;
                    break;
                case BirdColor.Yellow:
                    vX *= 2;
                    vY *= 2;
                    break;
            }
        }

        public void SetSmallRadius()
        {
            radius /= 2;
        }

        public void SetSpeed()
        {
            vX += blueAcceleration;
        }

        protected override void Timer_Tick(object sender, EventArgs e)
        {
            base.Timer_Tick(sender, e);
            CheckPosition();
            CheckSpeed();
        }

        protected override void Go()
        {
            base.Go();
            vY += g;
        }

        private void CheckSpeed()
        {
            if (vX > -0.05f && vX < 0.05f)
            {
                vY = 0;
                vX = 0;

                if (mainBird)
                {
                    WaitReturnBird();
                }
                else
                {
                    Stop();
                    Clear();
                }
            }
        }

        private void WaitReturnBird()
        {
            --waitToRestart;

            if (waitToRestart == 0)
            {
                Stop();
                Clear();
                waitToRestart = 100;
                RandomColor();
                BasePosition();
                Show();

                if (barrier.IsDestroyed())
                {
                    OnReturnEvent();
                }
            }
        }

        private void RandomColor()
        {
            var countColor = Enum.GetNames(typeof(BirdColor)).Length;
            birdColor = (BirdColor)random.Next(countColor);

            switch (birdColor)
            {
                case BirdColor.Red:
                    color = Color.Red;
                    radius = 20;
                    break;
                case BirdColor.Blue:
                    color = Color.Blue;
                    radius = 15;
                    break;
                case BirdColor.Yellow:
                    color = Color.Yellow;
                    radius = 23;
                    break;
                case BirdColor.Black:
                    color = Color.Black;
                    radius = 20;
                    break;
            }
        }

        private void CheckPosition()
        {
            if (centerY + radius > form.ClientSize.Height)
            {
                OnEarthEvent();
                Clear();
                centerY = BottomSide() - 1;
            }


            for (int i = 0; i < pigs.Count; i++)
            {
                var summRadius = radius + pigs[i].GetRadius();
                var distanceBetweenCenters = Math.Sqrt(Math.Abs(Math.Pow(centerX - pigs[i].GetCenterX(), 2) + Math.Pow(centerY - pigs[i].GetCenterY(), 2)));

                if (distanceBetweenCenters <= summRadius)
                {
                    OnPigTouchedEvent(i);
                }
            }

            if (centerX - radius > form.ClientSize.Width)
            {
                vX = 0;
                CheckSpeed();
            }

            if (IsBirdTouchBarrier())
            {
                if (!isTouched)
                {
                    isTouched = true;
                    vX /= 3f;
                    vY /= 3f;
                    OnBarrierHitedEvent();
                }
            }
        }

        private bool IsBirdTouchBarrier()
        {
            var barrierPoinrX = barrier.GetX();
            var barrierPoinrY = barrier.GetY();
            var barrierWidth = barrier.GetWidth();
            var barrierHeight = barrier.GetHeight();

            var tempBirdX = centerX;
            var tempBirdY = centerY;

            if (centerX + radius < barrierPoinrX)
            {
                tempBirdX = barrierPoinrX;
            }
            else if (centerX - radius > barrierPoinrX + barrierWidth)
            {
                tempBirdX = barrierPoinrX + barrierWidth;
            }

            if (centerY + radius < barrierPoinrY)
            {
                tempBirdY = barrierPoinrY;
            }
            else if (centerY - radius > barrierPoinrY + barrierHeight)
            {
                tempBirdY = barrierPoinrY - barrierHeight;
            }

            return Math.Pow(centerX - tempBirdX, 2) + Math.Pow(centerY - tempBirdY, 2) <= Math.Pow(radius, 2);
        }

        private void OnEarthEvent()
        {
            OnEarth?.Invoke(this, EventArgs.Empty);
        }

        private void OnPigTouchedEvent(int currentPig)
        {
            OnPigTouched.Invoke(this, new PigEventArgs(currentPig));
        }

        private void OnBarrierHitedEvent()
        {
            OnBarrierHited.Invoke(this, EventArgs.Empty);
        }

        private void OnReturnEvent()
        {
            OnReturn?.Invoke(this, EventArgs.Empty);
        }

        private void BasePosition()
        {
            centerX = LeftSide();
            centerY = BottomSide() - 1;
            isTouched = false;
        }
    }
}