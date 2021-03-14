using MingweiSamuel.Camille.ChampionMasteryV4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IMasteryService
    {
        IEnumerable<ChampionMastery> GetChampionMastery(string encryptedSummonerId);
    }
}
