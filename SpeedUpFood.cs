using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    /*                              INDIVIDUAL EXTENSION RASMUS NILSSON
     * Individual extension of the program
     * This food speeds up the player that eats it until they press another movement key and
     * gives the player eating it more points.
     * This gives the player a tactical advantage if the player wants to play offensively and take out it's competition,
     * catching the other players off-guard.
     */
    
    class SpeedUpFood : FoodAbstract
    {
        Random random = new Random(DateTime.Now.Millisecond + 5000);
        public SpeedUpFood()
        {
            pen.Color = Color.Lime;
            Value = 3;
            FoodType = "SpeedUp";
        }

        public override void GenerateFood()
        {
            ColParams.X = random.Next(100, 500);
            ColParams.Y = random.Next(10, 350);
        }

    }
}
