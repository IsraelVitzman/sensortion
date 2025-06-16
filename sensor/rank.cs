using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    public class Rank
    {
        Dictionary<Action, int> ranks;
        AgentRankBehavior agentRankBehavior;

        public Rank()
        {
            agentRankBehavior = new AgentRankBehavior();

            ranks = new Dictionary<Action, int>()
            {
              { agentRankBehavior.FootSoldier, 2 },
              { agentRankBehavior.SquadLeader, 4 },
              { agentRankBehavior.SeniorCommander, 8 },
              { agentRankBehavior.OrganizationLeader, 10 }
            };
        }

        public Dictionary<Action, int> GetRank()
        {
            return ranks;
        }
    }

}
