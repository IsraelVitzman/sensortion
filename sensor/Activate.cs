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

            while (true)
            {   // לוגיקה לרוץ על הקאי שהוא סטרינג ולהשוות לסטרינג של השחקן מכניס אם קיים להוריד אותו מהדיקשנקי ולשים נקודה 
                foreach (string sensor in agent.GetAgent().Keys)
                {

                    
                    if (agent.GetAgent().Keys == null)
                    {
                        Console.WriteLine("ניצחת כל הכבוד !!!");
                        return;
                    }



                    if (sensorToPlayer.Equals(sensor))
                    {
                        

                        count += 1;

                        //לבדוק האם זה מפעיל את כל הפונקציות 
                        Console.WriteLine(agent.GetAgent()[sensor]);
                        //לבדוק שזה אפשרי במהלך התוכנית
                        agent.GetAgent().Remove(sensor);

                        Console.WriteLine($"{countForSensorIrani}מתוך   {count}קלעת !! נשאר ");

                    }

                   
                }
            }
        }
    }
}
