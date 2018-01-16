using System;
using System.Drawing;

namespace Snake
{
    class Food
    {
        public Rectangle Piece;
        private int x, y, width = 10, height = 10;

        public Food(Random rand)
        {

        }
        public void Draw(Graphics graphics)
        {

        }
        public void Generate(Random rand)
        {
            x = rand.Next(0, 30) * 10;
            y = rand.Next(0, 20) * 10;
        }
    }
}
