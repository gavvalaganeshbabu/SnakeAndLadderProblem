using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome to Snake And Ladder Game :");
            SnakeLadderGameStart();
        }
        public static void SnakeLadderGameStart()
        {
            Console.WriteLine("Please Enter your Name  :");
            string name = Console.ReadLine();
            Console.WriteLine("Please Roll The Die :");
            int StartPosition = 0;
            int PlayerPosition = 0;
            int gotLadderPosition = 0;
            int ByteSnakePosition = 0;
            Random rnd = new Random();
            int DieNumber = rnd.Next(0, 7);
            Console.WriteLine(DieNumber + " is your die number ");
            if (DieNumber == 0)
            {
                PlayerPosition += DieNumber;
                Console.WriteLine("Your Position At " + PlayerPosition);
            }
            else if (DieNumber == 2)
            {
                Console.WriteLine("Snake Bytes You Comes to Starting Position " + PlayerPosition);
            }
            else {
                Console.WriteLine("You Got ladder position at " + PlayerPosition + DieNumber);
            }

        }
    }
}
