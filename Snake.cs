using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    class Snake
    {
        internal int PlayerNum;
        public int PosX = 100, PosY = 100;
        public int VectorX, VectorY;
        internal Pen pen;
        internal bool Death = false;
        
        public Snake(int PlayerNumber, Pen Color)
        {
            PlayerNum = PlayerNumber;
            pen = Color;
        }
        public enum KeyCharsPlayerOne
        {
            W,
            A, 
            S, 
            D
        }

        public enum KeyCharsPlayerTwo
        {
            I,
            K,
            J,
            L
        }
        public void DrawSnake(Object objects, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(pen, PosX, PosY, 12, 12);
        }

        public void Set(int PosXSetter, int PosYSetter)
        {
            PosX = PosXSetter;
            PosY = PosYSetter;
        }
        public void Move()
        {
            PosX += VectorX;
            PosY += VectorY;
        }

        public void Movement(Object objects, KeyEventArgs e)
        {
            if (PlayerNum == 1)
            {
                if (e.KeyCode.ToString() == KeyCharsPlayerOne.W.ToString())
                {
                    Console.WriteLine("Move Up.");
                    VectorY = -2;
                    VectorX = 0;
                    Set(PosX, PosY);
                }
                if (e.KeyCode.ToString() == KeyCharsPlayerOne.S.ToString())
                {
                    Console.WriteLine("Move Down.");
                    VectorY = 2;
                    VectorX = 0;
                    Set(PosX, PosY);
                }
                if (e.KeyCode.ToString() == KeyCharsPlayerOne.A.ToString())
                {
                    Console.WriteLine("Move Left.");
                    VectorY = 0;
                    VectorX = -2;
                    Set(PosX, PosY);
                }
                if (e.KeyCode.ToString() == KeyCharsPlayerOne.D.ToString())
                {
                    Console.WriteLine("Move Right.");
                    VectorY = 0;
                    VectorX = 2;
                    Set(PosX, PosY);
                }
            }
            if (PlayerNum == 2)
            {
                if (e.KeyCode.ToString() == KeyCharsPlayerTwo.I.ToString())
                {
                    Console.WriteLine("Move Up.");
                    VectorY = -2;
                    VectorX = 0;
                    Set(PosX, PosY);
                }
                if (e.KeyCode.ToString() == KeyCharsPlayerTwo.K.ToString())
                {
                    Console.WriteLine("Move Down.");
                    VectorY = 2;
                    VectorX = 0;
                    Set(PosX, PosY);
                }
                if (e.KeyCode.ToString() == KeyCharsPlayerTwo.J.ToString())
                {
                    Console.WriteLine("Move Left.");
                    VectorY = 0;
                    VectorX = -2;
                    Set(PosX, PosY);
                }
                if (e.KeyCode.ToString() == KeyCharsPlayerTwo.L.ToString())
                {
                    Console.WriteLine("Move Right.");
                    VectorY = 0;
                    VectorX = 2;
                    Set(PosX, PosY);
                }
            }
            

        }
    }
}
