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

        public void FindAgent(string sensorToPlayer)
        {
            int countForSensorIrani = agent.GetAgentLengte();
            List<string> sensorsToScored = new List<string>();

            while (true)
            {
                
                if (countForSensorIrani == count)
                {
                    Console.WriteLine("ניצחת כל הכבוד !!!");
                    return;
                }

                foreach (string scored in sensorsToScored)
                {
                    

                }

                foreach (string sensor in agent.GetAgent().Keys.ToList()) 
                {
                    if (sensorToPlayer.Equals(sensor))
                    {
                        

                       
                        Console.WriteLine(agent.GetAgent()[sensor]());

                        sensorsToScored.Add(sensor);

                        Console.WriteLine($"{countForSensorIrani} מתוך {count} קלעת!! נשאר ");
                    }
                }

                
               
            }
        }




    }
}
