using System.Resources;

namespace Snake
{
    public class ColParams
    {
        public int X;
        public int Y;
        public int S;

        public ColParams(int RX, int RY, int Side)
        {
            X = RX;
            Y = RY;
            S = Side;
        }
    }
}