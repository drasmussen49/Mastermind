using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class Game
    {
        public int[] masterArray = new int[4];

        public int[] MasterArray { get; set; }

        public Game()
        {
            MasterArray = masterArray;
            SetMasterArray();
            WelcomeMessage();
        }

        public void SetMasterArray()
        {
            Random rnd = new Random();
            int firstNum = rnd.Next(1, 7);
            int secondNum = rnd.Next(1, 7);
            int thirdNum = rnd.Next(1, 7);
            int fourthNum = rnd.Next(1, 7);
            MasterArray[0] = firstNum;
            MasterArray[1] = secondNum;
            MasterArray[2] = thirdNum;
            MasterArray[3] = fourthNum;
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Mastermind. \n4 random numbers have been generated 1 through 6 - you will try to guess what these numbers are and in which order.");
            Console.WriteLine("You have 10 guesses. A minus sign (-) will denote a correct number in a wrong location, and a a plus sign (+) will denote a correct number in a correct position. \nGood luck!");
        }
    }
}
