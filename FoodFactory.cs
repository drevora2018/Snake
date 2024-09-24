using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    interface FoodFactory
    {
        void GenerateFood();
        void DrawFood(PaintEventArgs e);
    }
}
