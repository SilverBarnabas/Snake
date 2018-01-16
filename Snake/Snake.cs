using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace Snake
{
    public class Snake
    {
        public Rectangle[] Body;
        private int x = 0, y = 0, width=10, height=10;

        public Snake()
        {

        }
        public void Draw()
        {

        }
        public void Draw(Graphics graphics)
        {

        }
        public void Move(int direction) //https://www.youtube.com/watch?v=3mq6SuT1aAs
        {
            Draw();
            switch (direction)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        public void Grow()
        {
            List<Rectangle> temp = Body.ToList();
            temp.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, height));
            Body = temp.ToArray();
        }
    }
}
