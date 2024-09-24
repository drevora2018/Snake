using System.Windows.Forms;

namespace Snake
{
    public struct KeyChars
    {
        public Keys Up;
        public Keys Down;
        public Keys Left;
        public Keys Right;

        public KeyChars(Keys up, Keys down, Keys left, Keys right )
        {
            Up = up;
            Down = down;
            Left = left;
            Right = right;
        }
    }
}