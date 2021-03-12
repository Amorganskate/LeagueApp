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
            return RiotApi.NewInstance("RGAPI-215170d2-30a8-4dbb-957c-6f58da7a71f0");
        }
    }
}
