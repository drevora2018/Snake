using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    class NormalFood : FoodAbstract
    {
        Random random = new Random(DateTime.Now.Millisecond);
        public NormalFood()
        {
            pen.Color = Color.Green;
            Value = 1;
            FoodType = "Normal";
        }

        public override void GenerateFood()
        {
            ColParams.X = random.Next(100, 500);
            ColParams.Y = random.Next(10, 350);
        }
    }
}
