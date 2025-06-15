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


        private string[] agentIrani;

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
        
        public  void NewAgent()
        {

        }
    }
}
