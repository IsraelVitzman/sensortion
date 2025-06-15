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

        public void FindAgent()
        {    
            // לוגיקה לרוץ על הקאי שהוא סטרינג ולהשוות לסטרינג של השחקן מכניס אם קיים להוריד אותו מהדיקשנקי ולשים נקודה 
            foreach (string sensor in agent.getAgent().Keys)
            {

                
            }

        }
    }
}
