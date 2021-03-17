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
            return RiotApi.NewInstance("RGAPI-a99d9a73-d03c-4943-9913-6233e3211023");
        }
    }
}
