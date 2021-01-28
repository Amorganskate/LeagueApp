using LeagueApp.Code;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChampionMastryController : ControllerBase
    {
        [HttpGet]
        public List<ChampionMastry> Get()
        {
            var request = RestService.create_rest_request("/lol/champion-mastery/v4/champion-masteries/by-summoner/sM8KVoKcCFVyCXSOjlOci_U0daZiLPKMlF2dSVXAIt9VOFc", Method.GET);

            try
            {
                var response = RestService.rest_client().Execute<List<ChampionMastry>>(request);

                return response.Data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
