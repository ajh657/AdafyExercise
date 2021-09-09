using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdafyExercise.Data
{
    public class Standing
    {
        public Team team;
        public int gamesPlayed = 1;
        public int Wins;
        public int Ties;
        public int Losses;
        public int GoalsScored;
        public int GoalsAgainst;
        public int GoalDiff;
        public int points;

        public Standing()
        {
        }

        public Standing(Team team)
        {
            this.team = team;
        }
    }
}
