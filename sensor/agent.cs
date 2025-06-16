using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class Agent
    {   
        Random random= new Random();

        SensorFectory sensorFectory;
        Rank rank;

       
        Dictionary<string, Func<string>> iraniAgent;



        Action selectedKey;
        int selectedValue;
        int randSensorActions;


        public  void NewAgent(string name)
        {
            iraniAgent = new Dictionary<string, Func<string>>();

            var randomEntry = rank.GetRank().ElementAt(random.Next(rank.GetRank().Count));

            
            selectedKey = randomEntry.Key;
            selectedValue = randomEntry.Value;


            List<string> keys = sensorFectory.getSensorFectory().Keys.ToList();

            for (int i = 0; i < selectedValue; i++) 
            {
                randSensorActions=random.Next(keys.Count);

                
                iraniAgent.Add(keys[randSensorActions], sensorFectory.getSensorFectory()[keys[randSensorActions]]);


            }
        }

        public Dictionary<string, Func<string>> GetAgent()
        {   
            return iraniAgent;
        }


        public int GetAgentLengte()
        {
            return iraniAgent.Count();
        }

        public Action getRank()
        {
            return selectedKey;
        }
       
        

    }
}
