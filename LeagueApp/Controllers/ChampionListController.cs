using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChampionListController : ControllerBase
    {

        public RootChampionDTO Get()
        {
            var client = new RestClient("http://ddragon.leagueoflegends.com/");
            var request = new RestRequest("cdn/6.24.1/data/en_US/champion.json", Method.GET);

            var response = client.Execute<RootChampionDTO>(request);

            return JsonConvert.DeserializeObject<RootChampionDTO>(response.Content);
        }
    }
}
