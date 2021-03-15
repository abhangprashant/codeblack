using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Training
{
    enum CurrentRole
    {
        Batsman,
        Bowler,
        Fielder
    }

    interface IPlayerRecord
    {
        string name { get; set; }
        int age { get; set; }
        int runScore { get; set; }
        int wicketScore { get; set; }
        int matchPlayed { get; set; }
    }



    class PlayerLiveStatus: IPlayerRecord
    {
        CurrentRole currentStatus;
        public string name { get; set; }
        public int age { get; set; }
        public int runScore { get; set; }
        public int wicketScore { get; set; }
        public int matchPlayed { get; set; }

    }

}
