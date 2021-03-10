using System;
using System.Threading.Tasks;
using MingweiSamuel.Camille.SummonerV4;

namespace Interfaces
{
    public interface ISummonerService
    {
        Task<Summoner> GetSummonerDetails(string SummonerName);

    }
}
