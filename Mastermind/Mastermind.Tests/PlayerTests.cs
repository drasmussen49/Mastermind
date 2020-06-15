using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mastermind.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void InputCheckerReturnsFalseWhenGivenNotAnInteger()
        {
           Player player = new Player();

           Assert.False(player.InputChecker("a"));
        }

        [Fact]
        public void InputCheckerReturnsTrueWhenGivenNotAnInteger()
        {
            Player player = new Player();

            Assert.True(player.InputChecker("2"));
        }
    }
}
