using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class Player
    {
        public int[] playerArray = new int[4];

        public int GuessCounter { get; set; }
        public int[] PlayerArray { get; set; }

        public Player()
        {
            PlayerArray = playerArray;
            GuessCounter = 0;
        }

        //public int[] PlayerGuess()
        //{
        //    Console.WriteLine("\nType a number 1 through 6");
        //    string playerInput = Console.ReadLine();
        //    InputChecker(playerInput);
        //}

        public bool InputChecker(string input)
        {
            int convertedNum;
            bool isNum = int.TryParse(input, out convertedNum);
            if (isNum == true && convertedNum > 0 && convertedNum < 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
