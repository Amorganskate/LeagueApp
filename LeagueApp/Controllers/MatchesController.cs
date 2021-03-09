using LeagueApp.Code;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchesController : ControllerBase
    {
        [HttpGet]
        public Object Get(string accountid)
        {
            return default;
        }
    }

}
