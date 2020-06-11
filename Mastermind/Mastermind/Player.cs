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
    }
}
