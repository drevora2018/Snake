using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public interface IPlayer
    {
        void DrawSnake(PaintEventArgs e);
        void Movement(Object sender, KeyEventArgs e);
        void Move();
        void Grow();
        void Shrink();
    }
}