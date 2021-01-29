using LeagueApp.Code;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using RestSharp;
using RiotSharp;
using RiotSharp.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RiotSharp.Endpoints.MatchEndpoint;

namespace LeagueApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchesController : ControllerBase
    {
        [HttpGet]
        public List<MatchReference> Get(string accountid)
        {
            var api = RiotApi.GetDevelopmentInstance("RGAPI-70d561bc-fc18-4b87-b517-a51e55ccf0ac");

            if (accountid != null)
            {
                try
                {
                    var allVersion = api.StaticData.Versions.GetAllAsync().Result;
                    var latestVersion = allVersion[0]; // Example of version: "10.23.1"
                    var matches =  api.Match.GetMatchListAsync(Region.Na, accountid).Result.Matches;
                    var champions = api.StaticData.Champions.GetAllAsync(latestVersion).Result.Champions.FirstOrDefault(x => x.Value.Id == matches.FirstOrDefault().ChampionID);
                    var champ_key = "http://ddragon.leagueoflegends.com/cdn/11.2.1/img/champion/" + api.StaticData.Champions.GetByKeyAsync(champions.Key, latestVersion).Result.Image.Full;
                    return matches;
                }
                catch (RiotSharpException ex)
                {
                    // Handle the exception however you want.
                }
            }
            return default;
        }
    }

}
