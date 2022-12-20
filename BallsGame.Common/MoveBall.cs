using System.Windows.Forms;

namespace BallsGame.Common
{
    public class MoveBall : RandomPointAndSizeBall
    {
        public MoveBall(Form form) : base(form)
        {
            vX = random.Next(-3, 4);
            vY = random.Next(-3, 4);

            if (vX == 0 && vY == 0)
            {
                vX = random.Next(-3, 4);
                vY = random.Next(-3, 4);
            }
        }
    }
}
