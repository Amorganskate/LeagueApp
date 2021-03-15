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
    public class MatchsService : IMatchsService
    {
        IRiotApi _RiotApi;
        ISummonerService _summonerService;

        public MatchsService(IRiotApi RiotApi, ISummonerService summonerService)
        {
            _RiotApi = RiotApi;
            _summonerService = summonerService;
        }

        public MingweiSamuel.Camille.MatchV4.Matchlist GetMatchList(string AccountId)
        {
            var riotApi = _RiotApi.GetRiotApi();

            return riotApi.MatchV4.GetMatchlist(Region.NA, AccountId);
        }

        public async Task<IEnumerable<RankedMatchDetails>> GetRankedMatchDetails(string SummonerName, int GameCount = 10)
        {
            var SummonerDetails = _summonerService.GetSummonerDetails(SummonerName);

            var MatchList = GetMatchList(SummonerDetails.AccountId);

            var MatchDataTasks = MatchList.Matches.Select(
                                   matchMetadata => _RiotApi.GetRiotApi().MatchV4.GetMatchAsync(Region.NA, matchMetadata.GameId)).Take(10).ToArray();

            var matches = await Task.WhenAll(MatchDataTasks);

            var ListRankedMatchs = new List<RankedMatchDetails>();
            foreach(var match in matches)
            {
                var RankedMatch = new RankedMatchDetails(match, SummonerDetails.Id);

                ListRankedMatchs.Add(RankedMatch);
            }

            return ListRankedMatchs;

        }
    }
}
