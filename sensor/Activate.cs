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
        Agent agent = new Agent();
        int count = 0;
       

        public void FindAgent(string sensorToPlayer)
        {   //יכול להיות להיות בעיה שהוא יוריד ..
            int countForSensorIrani = agent.GetAgentLengte();
            // לוגיקה לרוץ על הקאי שהוא סטרינג ולהשוות לסטרינג של השחקן מכניס אם קיים להוריד אותו מהדיקשנקי ולשים נקודה 
            foreach (string sensor in agent.GetAgent().Keys)
            { 

                if (sensorToPlayer.Equals(sensor)) 
                { 
                    agent.GetAgent().Remove(sensor);
                    count += 1;
                    Console.WriteLine($"{countForSensorIrani}מתוך   {count}קלעת !! נשאר ");
                }
                
            }

        }
    }
}
