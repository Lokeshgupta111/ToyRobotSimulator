using System;
using RobotSimulator;

namespace RobotSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int x, y;
           
            Console.Write("Enter an X: ");

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Invalid X! Please enter a valid integer: ");
            }
            Console.Write("Enter an Y: ");

            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Invalid Y! Please enter a valid integer: ");
            }

            Console.Write("Enter a Direction for moving Robot: ");
            string sDirection = Console.ReadLine();
            sDirection = sDirection.ToUpper();
            if (!Enum.TryParse(sDirection, true, out Face direction))
            {
                Console.WriteLine("Invalid Direction. Please enter a valid Direction.");
                return;
            }
            ToyRobot toy = new ToyRobot();

            if (toy.Place(x, y, direction))
            {
                toy.Left();
                toy.Move();
                toy.Move();
                toy.Left();
                toy.Move();
            }
            toy.Report();
        }
    }
}
