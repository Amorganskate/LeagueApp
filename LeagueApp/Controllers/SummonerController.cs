using LeagueApp.Code;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RiotSharp;
using RiotSharp.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LeagueApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SummonerController : ControllerBase
    {
        // AccountID: n66wz8wIST776e4rikLAiq1jEGtOZEGRpHN5Rj2tHrCiCu0
        // Encrypted SummonerID: sM8KVoKcCFVyCXSOjlOci_U0daZiLPKMlF2dSVXAIt9VOFc
        [HttpGet]
        public RiotSharp.Endpoints.SummonerEndpoint.Summoner Get(string summoner_name, Region region)
        {
            var api = RiotApi.GetDevelopmentInstance("RGAPI-70d561bc-fc18-4b87-b517-a51e55ccf0ac");


            try
            {
                return api.Summoner.GetSummonerByNameAsync(region, summoner_name).Result;

            }
            catch (RiotSharpException ex)
            {
                // Handle the exception however you want.
            }

            return default;
        }

        
    }
}
