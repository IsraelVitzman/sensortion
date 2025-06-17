using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class Activate
    {
        private Agent agent;
        private GameState gameState;
        private AgentRankBehavior rankBehavior;
        private int count;

        public Activate()
        {
            agent = new Agent();
            gameState = new GameState();
            rankBehavior = new AgentRankBehavior(gameState);
            count = 0;
        }

        public void StartGame()
        {
            agent.NewAgent();
        }

        public void FindAgent(string sensorToPlayer)
        {
            if (count >= agent.GetAgentLength())
            {
                Console.WriteLine("ניצחת");
                return;
            }

            bool foundSensor = false;

            foreach (string sensor in agent.GetAgent().Keys.ToList())
            {
                if (sensorToPlayer.Equals(sensor))
                {
                    Console.WriteLine(agent.GetAgent()[sensor]());

                    gameState.AddScored(sensor);

                    count++;

                    foundSensor = true;

                    Console.WriteLine($"קלעת!! נשאר {agent.GetAgentLength() - count} מתוך {agent.GetAgentLength()}");

                  
                    rankBehavior.ExecuteRankAction(agent.GetRank());

                    break;
                }
            }

            Console.WriteLine($" נשאר {agent.GetAgentLength() - count} מתוך {agent.GetAgentLength()}");


            if (count >= agent.GetAgentLength())
            {
                Console.WriteLine("ניצחת");
            }
        }

        public List<string> GetScored()
        {
            return gameState.GetScored();
        }

        public int GetLengthScored()
        {
            return gameState.GetLengthScored();
        }
    }
}




    

