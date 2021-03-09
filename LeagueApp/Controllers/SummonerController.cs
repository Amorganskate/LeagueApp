using LeagueApp.Code;
using Microsoft.AspNetCore.Mvc;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
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
        public object Get(string SummonerName)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-c8c3e2a4-edaf-4c3d-ad4f-dc32d540da9c");

            return riotApi.SummonerV4.GetBySummonerName(Region.NA, SummonerName);
        }

        
    }
}
