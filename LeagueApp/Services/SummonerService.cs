using Interfaces;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Services
{
    public class SummonerService : ISummonerService
    {
        public async Task<MingweiSamuel.Camille.SummonerV4.Summoner> GetSummonerDetails(string SummonerName)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-c8c3e2a4-edaf-4c3d-ad4f-dc32d540da9c");

            return await riotApi.SummonerV4.GetBySummonerNameAsync(Region.NA, SummonerName);
        }


    }
}
