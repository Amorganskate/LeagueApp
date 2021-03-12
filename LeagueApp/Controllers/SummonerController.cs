using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LeagueApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SummonerController : ControllerBase
    {
        private readonly ISummonerService summonerService;

        public SummonerController(ISummonerService summonerService)
        {
            this.summonerService = summonerService;
        }

        // AccountID: n66wz8wIST776e4rikLAiq1jEGtOZEGRpHN5Rj2tHrCiCu0
        // Encrypted SummonerID: sM8KVoKcCFVyCXSOjlOci_U0daZiLPKMlF2dSVXAIt9VOFc
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Summoner>))]
        public IActionResult GetSummonerDetails(string SummonerName)
        {
            var summonerDetails = summonerService.GetSummonerDetails(SummonerName);
            if(summonerDetails == null)
            {
                return NotFound();
            }
            return Ok(summonerService.GetSummonerDetails(SummonerName));
        }
    }
}
