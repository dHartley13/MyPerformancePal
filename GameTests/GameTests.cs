using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MyPerformacePal;
using Moq;
using Xunit;
using Xunit.Runner.TdNet;
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

        [Fact]
        public void When_ActionIsSaved_ActionIsSaveToTheDatabase()
        {
            //Setup
            var mockDB = new Mock<IGameDb>();
            mockDB.Setup(m => m.CreateGame())
                .Returns(123);

            var game = new Game(mockDB.Object);
            game.StartGame();

            //Execute
            game.RecordAction(1, "Retained", "Scrum", 50, 50);

            //Test
            mockDB.Verify(m => m.SaveAction(1, "Retained", 123, "Scrum", 50, 50), Times.Once);
        }

        [Fact]
        public void When_FirstActionIsSaved_StatsAreUpdated()
        {
            //Setup
            var mockDB = new Mock<IGameDb>();
            mockDB.Setup(m => m.CreateGame())
                .Returns(123);

            var game = new Game(mockDB.Object);
            game.StartGame();

            //Execute
            game.RecordAction(1, "Retained", "Scrum", 50, 50);
            var stats = game.GetStats();

            //Test
            Assert.NotNull(stats);
            Assert.True(stats.ContainsKey(1));
            Assert.Equal(1, stats[1]);
        }

        [Fact]
        public void When_SecondActionIsSaved_StatsAreUpdated()
        {
            //Setup
            var mockDB = new Mock<IGameDb>();
            mockDB.Setup(m => m.CreateGame())
                .Returns(123);

            var game = new Game(mockDB.Object);
            game.StartGame();

            //Execute
            game.RecordAction(1, "Retained", "Scrum", 50, 50);
            game.RecordAction(1, "Retained", "Scrum", 50, 50);
            var stats = game.GetStats();

            //Test
            Assert.NotNull(stats);
            Assert.True(stats.ContainsKey(1));
            Assert.Equal(2, stats[1]);
        }

    }
}
