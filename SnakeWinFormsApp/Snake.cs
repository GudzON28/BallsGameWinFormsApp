using BallsGame.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeWinFormsApp
{
    public class Snake : Ball
    {
        public event EventHandler OnOut;
        public event EventHandler OnFruitEat;
        private int countCells;
        private int sizeCell;
        private Direction travel = Direction.Right;
        private int fruitPositionX, fruitPositionY;

        public Snake(Form form, int sizeCell, int countCells, int indent) : base(form)
        {
            this.sizeCell = sizeCell;
            this.countCells = countCells;
            radius = sizeCell / 2 - 1;
            centerX = (sizeCell / 2 + indent) + sizeCell * random.Next(countCells - 3);
            centerY = (sizeCell / 2 + indent) + sizeCell * random.Next(countCells);
            timer.Interval = 300;
            color = Color.Red;
        }

        public Snake(Form form, int sizeCell, int positionX, int positionY, Direction direction, int indent) : base(form)
        {
            this.sizeCell = sizeCell;
            color = Color.OrangeRed;
            radius = sizeCell / 2 - (indent - 1);

            switch (direction)
            {
                case Direction.Left:
                    centerX = positionX + sizeCell;
                    centerY = positionY;
                    travel = direction;
                    break;
                case Direction.Right:
                    centerX = positionX - sizeCell;
                    centerY = positionY;
                    travel = direction;
                    break;
                case Direction.Up:
                    centerX = positionX;
                    centerY = positionY + sizeCell;
                    travel = direction;
                    break;
                case Direction.Down:
                    centerX = positionX;
                    centerY = positionY - sizeCell;
                    travel = direction;
                    break;
            }
        }

        public int GetPositionX()
        {
            return (int)centerX;
        }

        public int GetPositionY()
        {
            return (int)centerY;
        }

        public void SetPosition(int centerX, int centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }

        public Direction GetDirectionTravel()
        {
            return travel;
        }

        public void SetDirectionTravel(Direction directionTravel)
        {
            this.travel = directionTravel;
        }

        public void SetDirection(Keys key)
        {
            if (key == Keys.Down && travel != Direction.Up)
            {
                travel = Direction.Down;
            }

            if (key == Keys.Up && travel != Direction.Down)
            {
                travel = Direction.Up;
            }

            if (key == Keys.Left && travel != Direction.Right)
            {
                travel = Direction.Left;
            }

            if (key == Keys.Right && travel != Direction.Left)
            {
                travel = Direction.Right;
            }
        }

        public void CheckPosition()
        {
            if (centerX > countCells * sizeCell || centerX < 0 || centerY > countCells * sizeCell || centerY < 0)
            {
                OnOutEvent();
            }

            if (centerX == fruitPositionX && centerY == fruitPositionY)
            {
                OnFruitEatEvent();
            }
        }

        public void SaveFruitPosition(int fruitCenterX, int fruitCenterY)
        {
            fruitPositionX = fruitCenterX;
            fruitPositionY = fruitCenterY;
        }

        private void OnOutEvent()
        {
            OnOut?.Invoke(this, EventArgs.Empty);
        }

        private void OnFruitEatEvent()
        {
            OnFruitEat.Invoke(this, EventArgs.Empty);
        }
    }
}