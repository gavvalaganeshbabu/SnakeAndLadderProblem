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
            int PlayerPosition = 0;
            Random rnd = new Random();
            int DieNumber = rnd.Next(0, 7);
            Console.WriteLine(DieNumber + " is your die number ");
            int option =rnd.Next(0, 3);
            switch (option) {
                case 0:
                    Console.WriteLine("No play ");
                    Console.WriteLine("You are in Position At " + PlayerPosition);
                    break;
                case 1:
                    Console.WriteLine("You Got Ladder :");
                    Console.WriteLine("You are Position At " + PlayerPosition + DieNumber);
                    break;
                case 2:
                    Console.WriteLine("You caught up with Snake :");
                    Console.WriteLine("You are Position At " +( PlayerPosition - DieNumber));
                    break;
            }


        }
    }
}
