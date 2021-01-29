using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RiotSharp;
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

        public object Get()
        {
            var api = RiotApi.GetDevelopmentInstance("RGAPI-70d561bc-fc18-4b87-b517-a51e55ccf0ac");

            try
            {
                var allVersion = api.StaticData.Versions.GetAllAsync().Result;
                var latestVersion = allVersion[0]; // Example of version: "10.23.1"
                return api.StaticData.Champions.GetAllAsync(latestVersion).Result.Champions.Values;
            }
            catch (RiotSharpException ex)
            {
                // Handle the exception however you want.
            }

            return default;
        }

        //public object GetByName(string champname)
        //{
        //    var api = RiotApi.GetDevelopmentInstance("RGAPI-660382e2-41fd-4596-b88e-5a35894269a1");

        //    try
        //    {
        //        var allVersion = api.StaticData.Versions.GetAllAsync().Result;
        //        var latestVersion = allVersion[0]; // Example of version: "10.23.1"
        //        return api.StaticData.Champions.GetByKeyAsync(champname, latestVersion).Result;
        //    }
        //    catch (RiotSharpException ex)
        //    {
        //        // Handle the exception however you want.
        //    }

        //    return default;
        //}
    }
}
