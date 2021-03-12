using Domain.Common;
using Interfaces;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Services
{
    public class MatchsService : IMatchsService
    {
        IRiotApi _RiotApi;

        public MatchsService(IRiotApi RiotApi)
        {
            _RiotApi = RiotApi;
        }

        public MingweiSamuel.Camille.MatchV4.Matchlist GetMatchList(string AccountId)
        {
            var riotApi = _RiotApi.GetRiotApi();

            return riotApi.MatchV4.GetMatchlist(Region.NA, AccountId);
        }
    }
}
