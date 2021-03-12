using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MingweiSamuel.Camille.MatchV4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchsService matchService;

        public MatchController(IMatchsService summonerService)
        {
            this.matchService = summonerService;
        }

        // AccountID: n66wz8wIST776e4rikLAiq1jEGtOZEGRpHN5Rj2tHrCiCu0
        // Encrypted SummonerID: sM8KVoKcCFVyCXSOjlOci_U0daZiLPKMlF2dSVXAIt9VOFc
        [HttpGet("{AccountId}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Matchlist>))]
        public IActionResult GetMatchList(string AccountId)
        {
            var matchList = matchService.GetMatchList(AccountId);
            if(matchList == null)
            {
                return NotFound();
            }

            return Ok(matchList);
        }
    }
}
