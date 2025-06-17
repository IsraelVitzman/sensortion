
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    
    internal class AgentRankBehavior
    {
        private Random random = new Random();
        private GameState gameState;
        private int squadLeaderCount = 0;
        private int seniorCommanderCount = 0;
        private int organizationLeaderCount = 0;

        public AgentRankBehavior(GameState state)
        {
            gameState = state;
        }

        public void FootSoldier()
        {
            Console.WriteLine("אין התקפת נגד");
        }

        public void SquadLeader()
        {
            squadLeaderCount++;
            if (squadLeaderCount == 3)
            {
                if (gameState.GetScored().Count > 0)
                {
                    int randomIndex = random.Next(gameState.GetScored().Count);

                    string sensorToRemove = gameState.GetScored()[randomIndex];

                    gameState.RemoveScored(sensorToRemove);

                    Console.WriteLine("Squad Leader התקפת נגד! הוסר סנסור אחד!");
                }
                squadLeaderCount = 0;
            }
        }

        public void SeniorCommander()
        {
            seniorCommanderCount++;
            if (seniorCommanderCount == 3)
            {
                int sensorsToRemove = Math.Min(2, gameState.GetScored().Count);

                for (int i = 0; i < sensorsToRemove; i++)
                {
                    if (gameState.GetScored().Count > 0)
                    {
                        int randomIndex = random.Next(gameState.GetScored().Count);

                        string sensorToRemove = gameState.GetScored()[randomIndex];

                        gameState.RemoveScored(sensorToRemove);
                    }
                }
                if (sensorsToRemove > 0)
                {
                    Console.WriteLine($"Senior Commander התקפת נגד! הוסרו {sensorsToRemove} סנסורים!");
                }
                seniorCommanderCount = 0;
            }
        }

        public void OrganizationLeader()
        {
            organizationLeaderCount++;

            if (organizationLeaderCount == 10)
            {
                gameState.ClearScored();


                Console.WriteLine("Organization Leader התקפת נגד גדולה! כל הסנסורים הוסרו!");

                organizationLeaderCount = 0;
            }
            else if (organizationLeaderCount % 3 == 0)
            {
                if (gameState.GetScored().Count > 0)
                {
                    int randomIndex = random.Next(gameState.GetScored().Count);

                    string sensorToRemove = gameState.GetScored()[randomIndex];

                    gameState.RemoveScored(sensorToRemove);

                    Console.WriteLine("Organization Leader התקפת נגד! הוסר סנסור אחד!");
                }
            }
        }

        public void ExecuteRankAction(string rank)
        {
            switch (rank)
            {
                case "FootSoldier":
                    FootSoldier();
                    break;
                case "SquadLeader":
                    SquadLeader();
                    break;
                case "SeniorCommander":
                    SeniorCommander();
                    break;
                case "OrganizationLeader":
                    OrganizationLeader();
                    break;
            }
        }
    }
}
