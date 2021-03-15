using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Training
{
    /// <summary>
    /// Current data about both the team
    /// </summary>
    class Innings
    {
        public Teams currentBattingTeam;
        public Teams currentBowlingTeam;
        public Innings(Teams battingTeam, Teams bowlingTeam)
        {
            currentBattingTeam = battingTeam;
            currentBowlingTeam = bowlingTeam;
        }
        Teams teamA = new Teams("TeamA");
        Teams teamB = new Teams("TeamB");

        public int GetCurrentBatsmanscore()
        {
            return 100;
        }

        public int GetCurrentBowlerscore()
        {
            return 100;
        }

        public int GetCurrentTeamcore(Teams team)
        {
            return 100;
        }
    }
}
