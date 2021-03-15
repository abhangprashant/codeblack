using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Training
{
    enum TossResult
    {
        Head,
        Tail
    }

    enum InningDecision
    {
        Bat,
        Bowl
    }

    class Toss
    {
        public Teams team1, team2;

        public Toss(Teams team1, Teams team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }

        private TossResult FlipCoin()
        {
            return TossResult.Head;
        }

        private string TossWinner()
        {
            return "";
        }

        private InningDecision TeamDecision()
        {
            return InningDecision.Bat;
        }

        public Teams GetBattingTeam()
        {
            return team1;
        }


        public Teams GetBowlingTeam()
        {
            return team2;
        }
    }
}
