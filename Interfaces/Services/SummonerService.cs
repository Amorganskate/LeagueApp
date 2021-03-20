using Domain.Common;
using Domain.Entities;
using Interfaces;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Services
{
    public class SummonerService : ISummonerService
    {
        IRiotApi _RiotApi;

        public SummonerService(IRiotApi RiotApi)
        {
            _RiotApi = RiotApi;
        }

        public Summoner GetSummonerDetails(string SummonerName)
        {
           
            return new Summoner(_RiotApi.GetRiotApi().SummonerV4.GetBySummonerName(Region.NA, SummonerName));

        }

    }
}
