using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class Sensor
    {
        private string[] sensors;
        Random random =new Random();
        Agent agent;
        int countToPulse = 3;
        int countToMotion = 3;

        public Sensor()
        {
            sensors = new string[] { "Audio", "Thermal", "Pulse", "Motion", "Magnetic", "Signal", "Light" };
            
        }


        public string Audio()
        {
            return "";
        }


        public string Thermal()
        {
            List<string> keys = agent.GetAgent().Keys.ToList();
            return keys[random.Next(keys.Count)];
        }


        public string Pulse()
        {
            countToPulse -= 1;
            if (countToPulse == 0) 
            {
                agent.GetAgent().Remove("Pulse");
                return "remove Pulse";
            }
            return "";
        }


        public string Motion()
        {
            countToMotion -= 1;
            if (countToMotion == 0)
            {
                agent.GetAgent().Remove("Motion");
                return "remove Motion";
            }
            return "";

          
        }



        public string Magnetic()
        {

            // לקשר לפונקציה של הדרגות יש לבנות אותה בהמשך ..בקלאס .
            return "";
        }


        public string Signal()
        {

            return agent.getRank();
        }


        public string Light()
        {
            List<string> keys = agent.GetAgent().Keys.ToList();
            return $"{keys[random.Next(keys.Count)]} , {keys[random.Next(keys.Count)]}";

        }




    }
}
