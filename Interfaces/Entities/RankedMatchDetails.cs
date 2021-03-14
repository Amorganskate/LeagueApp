using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.MatchV4;

namespace Domain.Entities
{
    public class RankedMatchDetails 
    {
        public RankedMatchDetails(Match match, string SummonerID)
        {
            var Participant = FindParticipant(match, SummonerID);
            this.Wins = Participant.Stats.Win;
            this.Champion = (Champion)Participant.ChampionId;
            this.Kills = Participant.Stats.Kills;
            this.Deaths = Participant.Stats.Deaths;
            this.Assists = Participant.Stats.Assists;
            
        }

        public bool Wins { get; set; }
        public object Champion { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public string KDA
        {
            get{ return ((Kills + Assists) / (float)Deaths).ToString(); }
        }

        private Participant FindParticipant(Match match, string SummonerID)
        {
            var participantIdData = match.ParticipantIdentities.First(p1 => SummonerID.Equals(p1.Player.SummonerId));

            return  match.Participants
                .First(p => p.ParticipantId == participantIdData.ParticipantId);
        }
    }
}
