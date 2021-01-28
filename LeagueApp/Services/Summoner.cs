using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApp.Services
{
    public class Summoner
    {

        private static RestClient rest_client()
        {
            var client = new RestClient("https://na1.api.riotgames.com");
            return client;
        }

        private static RestRequest create_rest_request(string resource, Method method)
        {
            var request = new RestRequest(resource, method);
            request.AddParameter("X-Riot-Token", "RGAPI-c0901a09-1dc5-4fd8-b188-000073459b90");
            return request;
        }
        
        private static Summoner GetSummoner()
        {
            var request = create_rest_request("/lol/summoner/v4/summoners/by-name/tiltmasterflex1", Method.GET);

            try
            {
                var response = rest_client().Execute<Summoner>(request);

                return response.Data;
            }
            catch(Exception ex)
            {

            }

            return default;
            
        }
    }
}
