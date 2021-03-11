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
        public MingweiSamuel.Camille.SummonerV4.Summoner GetSummonerDetails(string SummonerName)
        {
            var riotApi = RiotApi.NewInstance("RGAPI-0dfa579d-5074-4ec0-8b2b-086df01071c5");

            return riotApi.SummonerV4.GetBySummonerName(Region.NA, SummonerName);
        }

    }
}
