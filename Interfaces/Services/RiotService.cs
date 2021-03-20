using Domain.Common;
using MingweiSamuel.Camille;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class RiotService : IRiotApi
    {
        public RiotApi GetRiotApi()
        {
            return RiotApi.NewInstance("RGAPI-7549e339-9828-4598-9f1d-b3489fe9a244");
        }
    }
}
