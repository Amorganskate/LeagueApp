using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using MingweiSamuel.Camille.MatchV4;

namespace Interfaces
{
    public interface IMatchsService
    {
        Matchlist GetMatchList(string AccountId);
        Task<IEnumerable<RankedMatchDetails>> GetRankedMatchDetails(string SummonerName, int GameCount = 10);
    }
}
