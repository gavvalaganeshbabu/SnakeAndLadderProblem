using System;
using System.Security.Cryptography.X509Certificates;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome to Snake And Ladder Game :");
            Console.WriteLine("Please Enter your Name  :");
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();
            Player1GameStart();

        }
        public static void Player1GameStart()
        {
            int Player1Position = 0;
                      
            Random rnd = new Random();
            while (Player1Position <= 100)
            {
                int DieNumber = rnd.Next(0, 7);                
                int option1 = rnd.Next(0, 3);
                switch (option1)
                {
                    case 0:
                        Player1Position += 0;
                        break;
                    case 1:
                        Player1Position += DieNumber;
                        if (Player1Position >= 100) {
                            Console.WriteLine("Player 1 Won the Game");
                            
                        }
                        break;
                    case 2:
                        Player1Position -= DieNumber;
                        Player2GameStart();
                        break;
                } 
                 
            }          
        }
        public static void Player2GameStart()
        {
            int Player2Position = 0;
            while (Player2Position <= 100)
            {
                Random rnd =new Random();
                int DieNumber = rnd.Next(0, 7);
                int option = rnd.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Player2Position += 0;
                        break;
                    case 1:
                        Player2Position += DieNumber;
                        if (Player2Position >= 100) {
                            Console.WriteLine("Player 2 Won the match");
                            
                        }
                        break;
                    case 2:
                        Player2Position -= DieNumber;
                        Player1GameStart();
                        break;
                }

            }

        }
      
    }
}
