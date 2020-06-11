using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class Game
    {
        public int[] masterArray = new int[4];

        public int[] MasterArray { get; set; }
        public int GuessCounter { get; set; }

        public Game()
        {
            MasterArray = masterArray;
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
    }
}
