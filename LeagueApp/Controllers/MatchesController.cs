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

namespace LeagueApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchesController : ControllerBase
    {
        [HttpGet]
        public RiotSharp.Endpoints.MatchEndpoint.MatchList Get(string accountid)
        {
            var api = RiotApi.GetDevelopmentInstance("RGAPI-660382e2-41fd-4596-b88e-5a35894269a1");

            if (accountid != null)
            {
                try
                {
                    return api.Match.GetMatchListAsync(Region.Na, accountid).Result;
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
