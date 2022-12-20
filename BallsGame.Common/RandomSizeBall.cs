using System.Windows.Forms;

namespace BallsGame.Common
{
    public class RandomSizeBall : Ball
    {
        public RandomSizeBall(Form form) : base(form)
        {
            radius = random.Next(20, 50);
        }
    }
}
