using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game :");
            SnakeLadderStart();
        }
        static void SnakeLadderStart() {
            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            int StartPosition = 0;
            Console.WriteLine("Hi "+name + " your Game is Started at " + StartPosition);
        }
    }
}
