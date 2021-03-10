using Interfaces;
using LeagueApp.Controllers;
using LeagueApp.Services;
using Moq;
using System;
using Xunit;

namespace SummonerTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSummonerDetails()
        {
            var mock =  new Mock<ISummonerService>();

            mock.Setup(repo => repo.GetSummonerDetails("tiltmasterflex"));
            var controller = new SummonerController(mock.Object);

            Assert.NotNull(controller.GetSummonerDetails("tiltmasterflex1"));
        }
    }
}

