using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public class Player : IPlayer
    {
        public int Score { get; set; } = 0;
        public bool Alive = true;
        public int Num;

        public Label label = new Label();
        public ColParams ColParams;
        //Innehåller snakes kropp
        public List<Rectangle> Body;
        //State för att kolla om snake nyligen har ätit
        public bool justAte = false;

        Pen pen = new Pen(Color.Empty);
        KeyChars input;
        internal Vector vector;

        public Player(int playerNum, int posX, int posY, Color color,
            Keys up, Keys down, Keys left, Keys right)
        {
            Num = playerNum;
            input = new KeyChars(up, down, left, right);
            pen.Color = color;
            label.Location = new Point(30, (50 * Num) - 20);
            ColParams = new ColParams(posX, posY, 5);
            //Instansierar body
            Body = new List<Rectangle>();
            //Lägger till basen för kroppen
            Body.Add(new Rectangle(ColParams.X, ColParams.Y, ColParams.S, ColParams.S));
        }

        public void DrawSnake(PaintEventArgs e)
        {
            if (Alive)
            {
                //Ritar ut varje rektangel som finns i kroppen
                foreach (Rectangle piece in Body)
                {
                    e.Graphics.DrawRectangle(pen, piece);
                }
            }
        }

        public void Movement(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == input.Up)
            {
                vector.Y = -5;
                vector.X = 0;
            }
            else if (e.KeyCode == input.Down)
            {
                vector.Y = 5;
                vector.X = 0;
            }
            else if (e.KeyCode == input.Left)
            {
                vector.Y = 0;
                vector.X = -5;
            }
            else if (e.KeyCode == input.Right)
            {
                vector.Y = 0;
                vector.X = 5;
            }
        }

        public void Move()
        {
            ColParams.X += vector.X;
            ColParams.Y += vector.Y;
            //Nya positioner för snakes huvud
            var newPos = Body[0];
            var prevPos = Body[0];
            newPos.X += vector.X;
            newPos.Y += vector.Y;
            Body[0] = newPos;

            //Nya positioner för snakes kropp (dvs huvudets gamla positioner)
            for (int i = 1; i < Body.Count; i++)
            {
                newPos = prevPos;
                prevPos = Body[i];
                Body[i] = newPos;

            }
        }

        /// <summary>
        /// Lägger till en ny rektangel i body-listan
        /// </summary>
        public void Grow()
        {
            Body.Add(new Rectangle(Body[Body.Count - 1].X, Body[Body.Count - 1].Y, Body[Body.Count - 1].Width, Body[Body.Count - 1].Height));
        }

        /// <summary>
        /// Tar bort sista rektangeln i body-listan
        /// </summary>
        public void Shrink()
        {
            if (Body.Count <= 1)
            {
                return;
            }
            Body.Remove(Body[Body.Count - 1]);
        }

        internal void SetVector(int X, int Y)
        {
            vector.X = X;
            vector.Y = Y;
        }
    }
}