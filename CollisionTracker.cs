using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class CollisionTracker
    {
        //keeps track of collisions with walls and other objects. 
        public int playerRecCollision(Player player, 
                                    ColParams recTwo, Form1 form)
        {
            var rx = player.ColParams.X;
            var ry = player.ColParams.Y;
            var rw = player.ColParams.S;
            var rh = player.ColParams.S;

            var fx = recTwo.X;
            var fy = recTwo.Y;
            var fw = recTwo.S;
            var fh = recTwo.S;
            
            if (rx + rw >= fx &&       // r1 right edge past r2 left
                rx <= fx + fw &&       // r1 left edge past r2 right
                ry + rh >= fy &&       // r1 top edge past r2 bottom
                ry <= fy + fh) {       // r1 bottom edge past r2 top
                return 1;
            }
            

            if ((rx >= form.Width || rx <= 0) || 
                (ry >= form.Height || ry <= 0))
            {
                player.label.Text = $"Player {player.Num} dead.";
                player.Alive = false;
                return 2;
                //die
            }

            return 2;
        }

        /// <summary>
        /// Kollar kollision med sig själv.
        /// </summary>
        /// <param name="player">spelarobjektet</param>
        /// <returns>0 om kollision inte sker, 1 om kollision sker.</returns>
        public int playerSelfCollision(Player player)
        {
            //Kollar varje del av kroppen
            for (int i = 1; i < player.Body.Count; i++)
            {
                //Om hela rektangeln har exakt samma position som en annan i kroppen
                if (player.Body[0].X == player.Body[i].X && player.Body[0].Y == player.Body[i].Y)
                {
                    //Om spelaren precis har ätit och kolliderar med den nya biten av sin egen kropp räknas det inte som kollision
                    if (player.justAte && i == player.Body.Count-1)
                    {
                        return 0;
                    }
                    //Kollision sker
                    return 1;
                }
            }
            //Kollision sker inte
            return 0;
        }

        public int playerCollision(Player player1, Player player2)
        {

            if (player1.Body[0].X == player2.Body[0].X && player1.Body[0].Y == player2.Body[0].Y)
            {
                //Spelarnas huvuden kolliderar
                return 3;
            }

            //Kollar varje del av kroppen
            for (int i = 1; i < player2.Body.Count; i++)
            {
                //Om hela rektangeln har exakt samma position som en annan i kroppen
                if (player1.Body[0].X == player2.Body[i].X && player1.Body[0].Y == player2.Body[i].Y)
                {
                    //Kollision sker för spelare 1
                    return 1;
                }
                
            }
            for (int i = 1; i < player1.Body.Count; i++)
            {
                if (player2.Body[0].X == player1.Body[i].X && player2.Body[0].Y == player1.Body[i].Y)
                {
                    //Kollision sker för spelare 2
                    return 2;
                }
            }
            
            //Ingen kollision sker
            return 0;
        }
    }
}