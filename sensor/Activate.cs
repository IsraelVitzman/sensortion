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
        Agent agent;
        int count;
        List<string> sensorsToScored = new List<string>();
      


        public void FindAgent(string sensorToPlayer)
        {
            
          
            List<string> keys = agent.GetAgent().Keys.ToList();

            while (true)
            {
                
                if (count == agent.GetAgentLengte())
                {
                    Console.WriteLine("ניצחת");
                    return;
                }

                

                foreach (string sensor in agent.GetAgent().Keys.ToList()) 
                {
                    if (sensorToPlayer.Equals(sensor))
                    {
                        

                       
                        Console.WriteLine(agent.GetAgent()[sensor]());

                        sensorsToScored.Add(sensor);

                        Console.WriteLine($"{agent.GetAgentLengte()} מתוך {count} קלעת!! נשאר ");
                    }
                }

                foreach (string scored in sensorsToScored)
                {
                    if (!keys.Contains(scored))
                    {
                        count += 1;
                    }

                }



            }
        }
        public List<string> GetScored()
        {
            return sensorsToScored;
        }
        public int GetLengteScored()
        {
            return sensorsToScored.Count;
        }




    }
}
