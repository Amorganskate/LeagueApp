using System;
using System.Collections.Generic;
using System.Text;
using MingweiSamuel.Camille.SummonerV4;

namespace Domain.Entities
{
    public class Summoner : MingweiSamuel.Camille.SummonerV4.Summoner
    {
        public Summoner(MingweiSamuel.Camille.SummonerV4.Summoner summoner)
        {
            this.Name = summoner.Name;
            this.Id = summoner.Id;
            this.AccountId = summoner.AccountId;
            this.ProfileIconId = summoner.ProfileIconId;
            this.Puuid = summoner.Puuid;
            this.RevisionDate = summoner.RevisionDate;
            this.SummonerLevel = summoner.SummonerLevel;
            this._AdditionalProperties = summoner._AdditionalProperties;
        }

        public string ProfileImageUrl
        {   
            get
            {
                return (this.ProfileIconId != 0) ? string.Format("http://ddragon.leagueoflegends.com/cdn/9.3.1/img/profileicon/{0}.png", this.ProfileIconId) : "";
            }
        }
    }
}
