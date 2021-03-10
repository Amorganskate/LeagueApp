using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille.MatchV4;

namespace Interfaces
{
    public interface IMatchsService
    {
        Task<Matchlist> GetMatchList(string AccountId);
    }
}
