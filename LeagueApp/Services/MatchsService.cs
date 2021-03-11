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
        public async Task<MingweiSamuel.Camille.MatchV4.Matchlist> GetMatchList(string AccountId)
        {
            var riotApi = RiotApi.NewInstance(new RiotApiConfig.Builder("RGAPI-c8c3e2a4-edaf-4c3d-ad4f-dc32d540da9c")
            {
                MaxConcurrentRequests = 200,
                Retries = 10,
                // ...
            }.Build());

            return await riotApi.MatchV4.GetMatchlistAsync(Region.NA, AccountId);

        }
    }
}
