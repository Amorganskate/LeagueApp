using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {

        public List<string> Get()
        {
            return new List<string>()
            {
                { "br" },
                { "eune" },
                { "euw" },
                { "global" },
                { "kr" },
                { "lan" },
                { "las" },
                { "na" },
                { "oce" },
                { "ru" },
                { "tr" }
            }.Select(x => x.ToUpper()).ToList();
        }
    }
}
