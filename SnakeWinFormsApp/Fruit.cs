using BallsGame.Common;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeWinFormsApp
{
    public class Fruit : Ball
    {
        public Fruit(Form form, int sizeCell, int countCells, int indent) : base(form)
        {
            radius = sizeCell / 2 - 1;
            centerX = (sizeCell / 2 + indent) + sizeCell * random.Next(countCells);
            centerY = (sizeCell / 2 + indent) + sizeCell * random.Next(countCells);
            color = Color.Green;
        }

        public int GetPositionX()
        {
            return (int)centerX;
        }

        public int GetPositionY()
        {
            return (int)centerY;
        }
    }
}
