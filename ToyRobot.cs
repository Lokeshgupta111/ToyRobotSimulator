using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSimulator
{
    public enum Face
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }
    public class ToyRobot
    {
        public int x = 0, y = 0;
        public Face f;


        public bool Place(int x, int y, Face f)
        {
            this.x = x;
            this.y = y;
            this.f = f;
            if (x > 5 || x < 0 || y > 5 || y < 0) return false;
            //Console.WriteLine($"Toy placed at {x}, {y}, {(Face)f}");
            return true;
        }

        public void Move()
        {
            if (f == Face.EAST && x < 5)
                x += 1;
            if (f == Face.WEST && x > 0)
                x -= 1;
            if (f == Face.NORTH && y < 5)
                y += 1;
            if (f == Face.SOUTH && y > 0)
                y -= 1;


        }

        public void Left()
        {
            if (f == (Face)0) f = (Face)3;
            else f -= 1;
        }

        public void Right()
        {
            if (f == (Face)3) f = (Face)0;
            else f += 1;

        }
        public void Report()
        {
            if (x > 5 || x < 0 || y > 5 || y < 0) { Console.WriteLine($"Output: Robot is off in the table."); return; }
            Console.WriteLine($"Output: {x}, {y}, {(Face)f}");
        }
    }

}

