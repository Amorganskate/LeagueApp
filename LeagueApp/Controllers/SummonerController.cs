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
            var api = RiotApi.GetDevelopmentInstance("RGAPI-c8c3e2a4-edaf-4c3d-ad4f-dc32d540da9c");


            try
            {
                return api.Summoner.GetSummonerBySummonerIdAsync(region, "sM8KVoKcCFVyCXSOjlOci_U0daZiLPKMlF2dSVXAIt9VOFc").Result;

            }
            catch (RiotSharpException ex)
            {
                // Handle the exception however you want.
            }

            return default;
        }

        
    }
}
