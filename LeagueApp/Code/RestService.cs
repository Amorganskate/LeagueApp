using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Code
{
    public class RestService
    {
        public static RestClient rest_client()
        {
            var client = new RestClient("https://na1.api.riotgames.com");
            return client;
        }

        public static RestRequest create_rest_request(string resource, Method method)
        {
            var request = new RestRequest(resource, method);
            request.AddParameter("api_key", "RGAPI-c0901a09-1dc5-4fd8-b188-000073459b90");
            return request;
        }
    }
}
