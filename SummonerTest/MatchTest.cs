using Interfaces;
using LeagueApp.Controllers;
using Moq;
using Xunit;

namespace SummonerTest
{
    public class MatchTest
    {
        [Fact]
        public void TestMatchList()
        {
            var mock = new Mock<IMatchsService>();


            mock.Setup(repo => repo.GetMatchList("n66wz8wIST776e4rikLAiq1jEGtOZEGRpHN5Rj2tHrCiCu0"));
            var controller = new MatchController(mock.Object);

            Assert.NotNull(controller.GetMatchList("n66wz8wIST776e4rikLAiq1jEGtOZEGRpHN5Rj2tHrCiCu0"));
        }
    }
}
