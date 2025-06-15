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
        private string[] rank;
        Sensor sensor=new Sensor();
        string [] agentIrani;
        private Dictionary<string, Func<string>> sensorActions;


        public agent()
        {
            rank = new string[] { "Foot Soldier", "Squad Leader", "Senior Commander", "Organization Leader" };
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
