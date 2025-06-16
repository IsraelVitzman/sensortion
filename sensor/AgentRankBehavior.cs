
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class AgentRankBehavior
    {
        Random random = new Random();
        Activate activate;
        int squadLeaderCount = 0;
        int seniorCommanderCount = 0;
        int organizationLeaderCount = 0;

        
      

        public void FootSoldier()
        {
            Console.WriteLine("אין התקפת נגד");
        }

        public void SquadLeader()
        {
            squadLeaderCount = squadLeaderCount + 1;
            if (squadLeaderCount == 3)
            {
                
                if (activate.GetScored().Count > 0)
                {
                    int randomIndex = random.Next(activate.GetScored().Count);
                    string sensorToRemove = activate.GetScored()[randomIndex];
                    activate.GetScored().Remove(sensorToRemove);
                    Console.WriteLine("Squad Leader התקפת נגד! הוסר סנסור אחד!");
                }
                squadLeaderCount = 0; 
            }
        }

        public void SeniorCommander()
        {
            seniorCommanderCount = seniorCommanderCount + 1;
            if (seniorCommanderCount == 3)
            {
                
                int sensorsToRemove = 2;
                if (activate.GetScored().Count < 2)
                {
                    sensorsToRemove = activate.GetScored().Count;
                }

                for (int i = 0; i < sensorsToRemove; i++)
                {
                    if (activate.GetScored().Count > 0)
                    {
                        int randomIndex = random.Next(activate.GetScored().Count);
                        string sensorToRemove = activate.GetScored()[randomIndex];
                        activate.GetScored().Remove(sensorToRemove);
                    }
                }

                if (sensorsToRemove > 0)
                {
                    Console.WriteLine("Senior Commander התקפת נגד! הוסרו " + sensorsToRemove + " סנסורים!");
                }
                seniorCommanderCount = 0; 
            }
        }

        public void OrganizationLeader()
        {
            organizationLeaderCount = organizationLeaderCount + 1;

            
            if (organizationLeaderCount == 10)
            {
                activate.GetScored().Clear();
                Console.WriteLine("Organization Leader התקפת נגד גדולה! כל הסנסורים הוסרו!");
                organizationLeaderCount = 0; 
            }
            
            else if (organizationLeaderCount % 3 == 0)
            {
                if (activate.GetScored().Count > 0)
                {
                    int randomIndex = random.Next(activate.GetScored().Count);
                    string sensorToRemove = activate.GetScored()[randomIndex];
                    activate.GetScored().Remove(sensorToRemove);
                    Console.WriteLine("Organization Leader התקפת נגד! הוסר סנסור אחד!");
                }
            }
        }

        

       

    }
}
