using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    class ValuableFood : FoodAbstract
    {
        Random random = new Random(DateTime.Now.Millisecond + 2000);
        public ValuableFood()
        {
            pen.Color = Color.Gold;
            Value = 5;
            FoodType = "Valuable";
        }

        public override void GenerateFood()
        {
            ColParams.X = random.Next(100, 500);
            ColParams.Y = random.Next(10, 350);
        }
    }
}
