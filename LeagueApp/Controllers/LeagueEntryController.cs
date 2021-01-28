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
    public class LeagueEntryController : ControllerBase
    {
        [HttpGet]
        public List<LeagueEntry> Get()
        {
            var request = RestService.create_rest_request("/lol/league/v4/entries/by-summoner/sM8KVoKcCFVyCXSOjlOci_U0daZiLPKMlF2dSVXAIt9VOFc", Method.GET);

            try
            { 
                var response = RestService.rest_client().Execute<List<LeagueEntry>>(request);

                return response.Data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
