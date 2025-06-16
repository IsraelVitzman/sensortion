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

        Sensor sensor;
        SensorFectory sensorFectory;
        Rank rank;

       
        Dictionary<string, Func<string>> iraniAgent;


        int randomRank;
        int randSensorActions;


      
        
        public  void NewAgent(string name)
        {
            iraniAgent = new Dictionary<string, Func<string>>();
            randomRank = random.Next(0, rank.getRank().Count);


            List<string> keys = sensorFectory.getSensorFectory().Keys.ToList();

            for (int i = 0; i < randomRank; i++) 
            {
                randSensorActions=random.Next(keys.Count);

                
                iraniAgent.Add(keys[randSensorActions], sensorFectory.getSensorFectory()[keys[randSensorActions]]);

                //צריך לטפל במצב שהוא כבר קיים בתוך האירני 
                // לבדוק שהקוד תקין מצד תחביר שלו


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



        

    }
}
