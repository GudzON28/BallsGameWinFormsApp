namespace BallsGameDiffusionWinFormsApp
{
    public class HitEventArgs
    {
        public Gas Gas;
        public Bump Side;

        public HitEventArgs(Gas gas, Bump side)
        {
            Gas = gas;
            Side = side;
        }
    }
}