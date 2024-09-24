using System;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    abstract class FoodAbstract : FoodFactory
    {
        internal int Value; //Gives Value amount of Score
        protected Random Random = new Random();
        protected Pen pen = new Pen(Color.Empty);
        public ColParams ColParams;
        public string FoodType;

        public FoodAbstract()
        {
            ColParams = new ColParams(0, 0, 10);
        }
        public void DrawFood(PaintEventArgs e) 
        {
            e.Graphics.DrawRectangle(pen, ColParams.X, ColParams.Y, ColParams.S, ColParams.S);
        }
        public virtual void GenerateFood() 
        {
            ColParams.X = Random.Next(100, 500);
            ColParams.Y = Random.Next(10, 350);
        }
    }
}