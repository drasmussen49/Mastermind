using System;
using Xunit;

namespace Mastermind.Tests
{
    public class GameTests
    {
        [Fact]
        public void CheckMasterArrayValuesNotZero()
        {
            Game game = new Game();
            
            game.SetMasterArray();

            Assert.DoesNotContain(0, game.masterArray);
        }
    }
}
