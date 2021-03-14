using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;
using Domain.Interfaces;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.ChampionMasteryV4;
using MingweiSamuel.Camille.Enums;

namespace Domain.Services
{
    public class MasteryService : IMasteryService
    {
        IRiotApi _RiotApi;
        public MasteryService(IRiotApi RiotApi)
        {
            _RiotApi = RiotApi;   
        }

        public IEnumerable<ChampionMastery> GetChampionMastery(string encryptedSummonerId)
        {
            var championMasteries = _RiotApi.GetRiotApi().ChampionMasteryV4.GetAllChampionMasteries(Region.NA, encryptedSummonerId);

            
            return championMasteries;
        }


    }
}
