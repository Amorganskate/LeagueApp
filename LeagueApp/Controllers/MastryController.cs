using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MingweiSamuel.Camille.ChampionMasteryV4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MastryController : ControllerBase
    {
        private readonly IMasteryService masteryService;

        public MastryController(IMasteryService masteryService)
        {
            this.masteryService = masteryService;
        }

        [HttpGet("{encryptedSummonerId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChampionMastery>))]
        public IActionResult GetSummonerDetails(string encryptedSummonerId)
        {
            var TopChampions = masteryService.GetChampionMastery(encryptedSummonerId);
            if (TopChampions == null)
            {
                return NotFound();
            }
            return Ok(TopChampions);
        }
    }
}
