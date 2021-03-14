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
            return RiotApi.NewInstance("RGAPI-83bfcb18-5b5e-4835-a40e-0f7a3fe86021");
        }
    }
}
