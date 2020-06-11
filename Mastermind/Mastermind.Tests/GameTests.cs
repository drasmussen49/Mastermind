using System;
using Xunit;

namespace Mastermind.Tests
{
    public class GameTests
    {
        [Fact]
        public void CheckMasterArrayValuesNotZero()
        {
            //arrange
            Game game = new Game();
            
            //act
            game.SetMasterArray();

            //assert
            Assert.DoesNotContain(0, game.masterArray);
        }
    }
}
