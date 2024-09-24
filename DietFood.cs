using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    class DietFood : FoodAbstract
    {
        Random random = new Random(DateTime.Now.Millisecond + 1000);
        public DietFood()
        {
            pen.Color = Color.Red;
            Value = 1;
            FoodType = "Diet";
        }

        public override void GenerateFood()
        {
            ColParams.X = random.Next(100, 500);
            ColParams.Y = random.Next(10, 350);
        }
    }
}
