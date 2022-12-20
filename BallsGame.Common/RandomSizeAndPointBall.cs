using System.Windows.Forms;

namespace BallsGame.Common
{
    public class RandomPointAndSizeBall : RandomSizeBall
    {
        public RandomPointAndSizeBall(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), BottomSide());
        }
    }
}
