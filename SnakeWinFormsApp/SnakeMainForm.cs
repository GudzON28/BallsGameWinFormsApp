using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeWinFormsApp
{
    public partial class SnakeMainForm : Form
    {
        private Pen delimiterColor = new Pen(Color.Black, 1);
        private int countCells;
        private int sizeCell = 20;
        private int indent = 3;
        private int buttonWidth = 75;
        private int buttonHeight = 21;
        private List<Snake> snake = new List<Snake>();
        private int positionX, positionY;
        private Direction direction;

        public SnakeMainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            Width = 600;
            Height = 545;
            countCells = ClientSize.Height / sizeCell;
            moveTimer.Interval = 500;
        }

        private void SnakeMainForm_Load(object sender, EventArgs e)
        {
            startButton.Location = new Point(ClientSize.Width - buttonWidth - indent, ClientSize.Height - buttonHeight - indent);
            totalScoreLabel.Location = new Point(ClientSize.Width - totalScoreLabel.Width - indent * 2, 10);
            scoreLabel.Location = new Point(ClientSize.Width - totalScoreLabel.Width - scoreLabel.Width - indent * 2, 10);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var headSnake = new Snake(this, sizeCell, countCells, indent);
            headSnake.OnOut += HeadSnake_OnOut;
            headSnake.OnFruitEat += HeadSnake_OnFruitEat;
            headSnake.Show();
            snake.Add(headSnake);
            startButton.Enabled = false;
            GenerateFruit();
            moveTimer.Start();
        }

        private void GenerateFruit()
        {
            var fruit = new Fruit(this, sizeCell, countCells, indent);
            snake[0].SaveFruitPosition(fruit.GetPositionX(), fruit.GetPositionY());
            fruit.Show();
        }

        private void HeadSnake_OnFruitEat(object? sender, EventArgs e)
        {
            totalScoreLabel.Text = (Convert.ToDouble(totalScoreLabel.Text) + 1).ToString();
            GenerateFruit();
            var bodySnake = new Snake(this, sizeCell, snake[snake.Count - 1].GetPositionX(), snake[snake.Count - 1].GetPositionY(), snake[snake.Count - 1].GetDirectionTravel(), indent);
            snake.Add(bodySnake);
        }

        private void HeadSnake_OnOut(object? sender, EventArgs e)
        {
            moveTimer.Stop();
            MessageBox.Show("За полем");
            return;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i <= countCells; i++)
            {
                e.Graphics.DrawLine(delimiterColor, i * sizeCell + indent, indent, i * sizeCell + indent, countCells * sizeCell + indent);
            }

            for (int i = 0; i <= countCells; i++)
            {
                e.Graphics.DrawLine(delimiterColor, indent, i * sizeCell + indent, countCells * sizeCell + indent, i * sizeCell + indent);
            }
        }

        private void SnakeMainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            snake[0].SetDirection(e.KeyCode);
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = snake.Count; i > 1; i--)
            {

                if (snake[0].GetPositionX() == snake[i - 1].GetPositionX() && snake[0].GetPositionY() == snake[i - 1].GetPositionY())
                {
                    moveTimer.Stop();
                    MessageBox.Show("Врезался в тело");
                    return;
                }

                snake[i - 1].Clear();

                positionX = snake[i - 2].GetPositionX();
                positionY = snake[i - 2].GetPositionY();
                direction = snake[i - 2].GetDirectionTravel();

                switch (direction)
                {
                    case Direction.Left:
                        snake[i - 1].SetDirectionTravel(Direction.Left);
                        snake[i - 1].SetPosition(positionX, positionY);
                        break;
                    case Direction.Right:
                        snake[i - 1].SetDirectionTravel(Direction.Right);
                        snake[i - 1].SetPosition(positionX, positionY);
                        break;
                    case Direction.Up:
                        snake[i - 1].SetDirectionTravel(Direction.Up);
                        snake[i - 1].SetPosition(positionX, positionY);
                        break;
                    case Direction.Down:
                        snake[i - 1].SetDirectionTravel(Direction.Down);
                        snake[i - 1].SetPosition(positionX, positionY);
                        break;
                }
            }

            snake[0].CheckPosition();
            snake[0].Clear();

            direction = snake[0].GetDirectionTravel();
            positionX = snake[0].GetPositionX();
            positionY = snake[0].GetPositionY();

            switch (direction)
            {
                case Direction.Left:
                    snake[0].SetPosition(positionX - sizeCell, positionY);
                    break;
                case Direction.Right:
                    snake[0].SetPosition(positionX + sizeCell, positionY);
                    break;
                case Direction.Up:
                    snake[0].SetPosition(positionX, positionY - sizeCell);
                    break;
                case Direction.Down:
                    snake[0].SetPosition(positionX, positionY + sizeCell);
                    break;
            }

            foreach (var snakeSegment in snake)
            {
                snakeSegment.Show();
            }
        }
    }
}