using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class agent
    {   
        Random random= new Random();
        Sensor sensor=new Sensor();

        Dictionary<String ,int> rank ;
        Dictionary<string, Func<string>> sensorActions;

        Dictionary<string, Func<string>> iraniAgent;


        public agent()
        {
           rank = new Dictionary<string, int>()
           {
               { "Foot Soldier", 2 },
               { "Squad Leader", 4 },
               { "Senior Commander", 8 },
               { "Organization Leader", 10 }
           };


           sensorActions = new Dictionary<string, Func<string>>()
           {
              { "Audio",sensor. Audio },
              { "Thermal",sensor. Thermal},
              { "Pulse",sensor. Pulse },
              { "Motion", sensor.Motion },
              { "Magnetic", sensor.Magnetic},
              { "Signal", sensor.Signal },
              { "Light", sensor.Light }
           };
        }   
        
        public  void NewAgent(string name)
        {
            iraniAgent = new Dictionary<string, Func<string>>();
            int randomRank = random.Next(0, rank.Count);


            List<string> keys = sensorActions.Keys.ToList();

            for (int i = 0; i < randomRank; i++) 
            {
                int randSensorActions=random.Next(keys.Count);

                
                iraniAgent.Add(keys[randSensorActions], sensorActions[keys[randSensorActions]]);

                //צריך לטפל במצב שהוא כבר קיים בתוך האירני 
                // לבדוק שהקוד תקין מצד תחביר שלו


            }
        }
    }
}
