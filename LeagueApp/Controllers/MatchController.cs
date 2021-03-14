using Domain.Entities;
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

        
//  "accountId": "n66wz8wIST776e4rikLAiq1jEGtOZEGRpHN5Rj2tHrCiCu0",
//  "profileIconId": 1113,
//  "revisionDate": 1615011266000,
//  "name": "TiltMasterFlex1",
//  "id": "sM8KVoKcCFVyCXSOjlOci_U0daZiLPKMlF2dSVXAIt9VOFc",
//  "puuid": "REokuSAlDm8zsmrAMCA6oStMAKFN0mzhnEwOq_sEVVqpVoCtodHCmrg2HxZixeio2I6bb2wJ0LIVpg",
//  "summonerLevel": 164
//}
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

        [HttpGet("/RankedMatches/{SummonerName}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RankedMatchDetails>))]
        public async Task<IActionResult> GetRankedMatchs(string SummonerName)
        {
            var RankedMatches = await matchService.GetRankedMatchDetails(SummonerName);

            if (RankedMatches == null)
            {
                return NotFound();
            }

            return Ok(RankedMatches);
        }
    }
}
