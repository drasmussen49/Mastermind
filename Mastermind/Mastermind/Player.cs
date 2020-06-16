using System;
using System.Collections.Generic;
using System.Linq;
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
            GuessCounter = 1;
        }

        public void PlayerGuess(Game game)
        {
            while (GuessCounter < 11)
            {
                Console.WriteLine("\n--------------------------------------------------------------------------------");
                Console.WriteLine($"\nGuess number {GuessCounter}.");
                for (int i=0; i<4; i++)
                {
                    bool hasGuessed = false;
                    while (hasGuessed == false)
                    {
                        Console.WriteLine("\nInput a number 1 through 6");
                        string playerInput = Console.ReadLine();
                        if (InputChecker(playerInput) == true)
                        {
                            int playerInputAsInt = int.Parse(playerInput);
                            playerArray[i] = playerInputAsInt;
                            hasGuessed = true;
                        }
                        else if (InputChecker(playerInput) == false)
                        {
                            Console.WriteLine("You did not input a a valid number. Numbers 1 though 6 are accepted.");
                        }
                    }
                }   
                string playerArrayDisplay = string.Join(",", playerArray).Replace(",", string.Empty);
                Console.WriteLine("\nYour guess is: " +"[" + playerArrayDisplay + "]");
                GuessCounter++;
                game.MasterArrayCompare(playerArray);
                if (playerArray.SequenceEqual(game.MasterArray))
                {
                    break;
                }
            }
            if (playerArray.SequenceEqual(game.MasterArray))
            {
                Console.WriteLine("\nPlease play again!");
            }
            else
            {
                Console.WriteLine("You did not guess correctly in 10 tries. Please play again!");
            }
        }

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
