using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdafyExercise.Data
{
    public class Match
    {
        public int Id;
        public object Round;
        public int RoundNumber;
        public DateTime MatchDate;
        public Team HomeTeam;
        public Team AwayTeam;
        public int HomeGoals;
        public int AwayGoals;
        public int Status;
        public int PlayedMinutes;
        public object SecondHalfStarted;
        public DateTime? GameStarted;
        public List<MatchEvent> MatchEvents;
        public List<object> PeriodResults;
        public bool OnlyResultAvailable;
        public int Season;
        public string Country;
        public string League;
    }

    public class Team
    {
        public int Id;
        public string Name;
        public string FullName;
        public object Logo;
        public string LogoUrl;
        public int Ranking;
        public string Message;
    }

    public class MatchEvent
    {
        public int Id;
        public int MatchId;
        public int EventMinute;
        public int ElapsedSeconds;
        public int TeamId;
        public string Description;
        public string FullDescription;
        public string EventTypeIcon;
        public string EventType;
        public int EventTypeEnum;
        public int PlayerId;
        public object Player;
        public string Identifier;
        public object AssistPlayers;
        public object AssistPlayerNames;
        public object Modifier;
        public object Score;
        public bool IsGoal;
    }
}
