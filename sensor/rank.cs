using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    public class Rank
    {
        private Dictionary<string, int> ranks;

        public Rank()
        {
            ranks = new Dictionary<string, int>()
            {
                { "FootSoldier", 2 },
                { "SquadLeader", 4 },
                { "SeniorCommander", 8 },
                { "OrganizationLeader", 10 }
            };
        }

        public Dictionary<string, int> GetRank()
        {
            return ranks;
        }

    }
}