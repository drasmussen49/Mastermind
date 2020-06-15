using System;

namespace Mastermind
{
    class Program
    {
        static void Main()
        {
            Game freshGame = new Game();
            Player player = new Player();
            player.PlayerGuess();
        }
    }
}
