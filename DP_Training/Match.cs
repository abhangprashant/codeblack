using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Training
{
    
    public class Match
    {
        // Teams
        static Teams team1 = new Teams("TeamA");
        static Teams team2 = new Teams("TeamB");


        // Toss: 
        static Toss TossCls  = new Toss(team1, team2);
        // Result: TeamA/TeamB: bowl/BaT based on TossWinner, TossResult and InningDecision 


        // inning starts
        // Match Statics: Batting | Bowling | player
        private static Teams battingTeam = TossCls.GetBattingTeam();

        private static Teams bowlingTeam = TossCls.GetBowlingTeam();


        Innings Inning1 = new Innings(battingTeam, bowlingTeam);
        Innings Inning2 = new Innings(bowlingTeam, battingTeam);

        



    }
}
