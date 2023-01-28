﻿using System;

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
            while (PlayerPosition <= 100) 
            {
                int DieNumber = rnd.Next(0, 7);
                if (DieNumber == 0)
                {
                    PlayerPosition += DieNumber;
                }
                //If Die gives 2 and playerPosition goes to every below mentioned intervals there would be a Snake byte to player
                else if (DieNumber == 2 && PlayerPosition == 12 || PlayerPosition == 22 || PlayerPosition == 34 || PlayerPosition == 44 || PlayerPosition == 74 ||PlayerPosition==84||PlayerPosition==94)
                {
                    PlayerPosition -= DieNumber;
                }
                else
                {
                    PlayerPosition += DieNumber;
                }
            }
            Console.WriteLine("Congratulation You Won The Game ");
            if (PlayerPosition > 100) { 
            PlayerPosition= 100;
            }
            Console.WriteLine(PlayerPosition);
        }
    }
}
