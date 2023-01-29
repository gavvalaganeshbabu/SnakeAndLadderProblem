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
            int DieCount = 0;
            Random rnd = new Random();
            while (PlayerPosition <= 100)
            {
                int DieNumber = rnd.Next(0, 7);
                DieCount++;
                int option = rnd.Next(0, 3);
                switch (option)
                {
                    case 0:
                        PlayerPosition += 0;
                        Console.WriteLine("Player Position = " + PlayerPosition);
                        break;
                    case 1:
                        PlayerPosition += DieNumber;
                        Console.WriteLine("Player Position = " + PlayerPosition);
                        break;
                    case 2:
                        PlayerPosition -= DieNumber;
                        Console.WriteLine("Player Position = " + PlayerPosition);
                        break;
                }
                if (PlayerPosition < 0)
                {
                    PlayerPosition = 0;
                    Console.WriteLine("Your Position =" + PlayerPosition);
                }
            }
            Console.WriteLine("Congratulation You Won The Game ");
            Console.WriteLine(DieCount);    
        }  
    }
}
