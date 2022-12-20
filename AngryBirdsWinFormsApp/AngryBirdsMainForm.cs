using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AngryBirdsWinFormsApp
{
    public partial class AngryBirdsMainForm : Form
    {
        private Bird bird;
        private Barrier barrier;
        private Random random = new Random();
        private List<Pig> pigs = new List<Pig>();
        private bool onceClicked = false;

        public AngryBirdsMainForm()
        {
            InitializeComponent();
            CreateBird();
            CreatePig();
            CreateBarrier();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            bird.Show();
            barrier.Draw();

            foreach (var pig in pigs)
            {
                pig.Show();
            }
        }

        private void CreateBird()
        {
            bird = new Bird(this);
            bird.OnEarth += Bird_OnEarth;
            bird.OnPigTouched += Bird_OnPigTouched;
            bird.OnBarrierHited += Bird_OnBarrierHited;
            bird.OnReturn += Bird_OnReturn;
        }

        private void Bird_OnReturn(object? sender, EventArgs e)
        {
            CreateBarrier();
        }

        private void Bird_OnBarrierHited(object? sender, EventArgs e)
        {
            barrier.Clear();
        }

        private void CreatePig()
        {
            var countPig = random.Next(3, 7);

            for (int i = 0; i < countPig; i++)
            {
                var pig = new Pig(this, maximumRightClickZone, maximumUpClickZone);
                pig.Show();
                pigs.Add(pig);
            }

            bird.SavePigs(pigs);
        }

        private void CreateBarrier()
        {
            barrier = new Barrier(this);
            barrier.Draw();
            bird.SaveBarrierPosition(barrier);
        }

        private void Bird_OnPigTouched(object? sender, PigEventArgs e)
        {
            pigs[e.currentPig].Clear();
            pigs.RemoveAt(e.currentPig);

            if (pigs.Count == 0)
            {
                CreatePig();
            }
            scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
        }

        private void Bird_OnEarth(object? sender, EventArgs e)
        {
            var currentBird = sender as Bird;
            currentBird.SlowMotion();
        }

        private void AngryBirdsMainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (bird.Restored() && e.X < maximumRightClickZone.Location.X && e.Y > maximumUpClickZone.Location.Y)
            {
                birdUsedLabel.Text = (Convert.ToInt32(birdUsedLabel.Text) + 1).ToString();
                bird.SetDirection(e.X, e.Y);
                bird.Start();
                onceClicked = false;
            }

            if (!bird.Restored() && !onceClicked)
            {
                onceClicked = true;

                var birdColor = bird.GetColor();

                switch (birdColor)
                {
                    case BirdColor.Blue:
                        bird.Clear();
                        bird.SetSmallRadius();

                        var smallBird = new Bird(this, barrier, bird, "lower");
                        GenerateSmalBird(smallBird);
                        smallBird = new Bird(this, barrier, bird, "upper");
                        GenerateSmalBird(smallBird);
                        bird.SetSpeed();
                        break;
                    case BirdColor.Yellow:
                        bird.SetNewParameters();
                        break;
                    case BirdColor.Black:
                        bird.SetNewParameters();
                        break;
                }
            }
        }

        private void GenerateSmalBird(Bird smallBird)
        {
            smallBird.OnEarth += Bird_OnEarth;
            smallBird.OnPigTouched += Bird_OnPigTouched;
            smallBird.OnBarrierHited += Bird_OnBarrierHited;
            smallBird.SavePigs(pigs);
            smallBird.Show();
            smallBird.Start();
        }
    }
}