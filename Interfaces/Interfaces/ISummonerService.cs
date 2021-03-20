using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISummonerService
    {
        Summoner GetSummonerDetails(string SummonerName);

    }
}
