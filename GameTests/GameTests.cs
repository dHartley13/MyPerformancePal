using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MyPerformacePal;
using Moq;
using Xunit;
using System.Threading.Tasks;

namespace GameTests
{
    public class GameTests
    {
        [Fact]
        public void When_GameIsStarted_Then_NewGameIdShouldBeStored()
        {
            //Setup
            var mockDB = new Mock<IGameDb>();
            mockDB.Setup(m => m.CreateGame())
                .Returns(123);

            var game = new Game(mockDB.Object);

            //Execute
            game.StartGame();

            //Test
            Assert.Equal(123, game.GameId);
        }
    }
}
