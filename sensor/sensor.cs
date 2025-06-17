using System;
using System.Collections.Generic;
using System.Linq;

namespace sensor
{
    internal class Sensor
    {
        private Agent agent;
        private int countToPulse;
        private int countToMotion;
        private Random random = new Random();

        public Sensor(Agent agentRef)
        {
            agent = agentRef;
            countToPulse = 3;
            countToMotion = 3;
        }

        public string Audio()
        {
            return "אין התקפת נגד";
        }

        public string Thermal()
        {
            List<string> keys = agent.GetAgent().Keys.ToList();
            if (keys.Count == 0)
            {
                return "אין חיישנים";
            }
            return keys[random.Next(keys.Count)];
        }

        public string Pulse()
        {
            countToPulse--;
            if (countToPulse == 0)
            {
                agent.RemoveSensor("Pulse");
                return "הוסר Pulse";
            }
            return "";
        }

        public string Motion()
        {
            countToMotion--;
            if (countToMotion == 0)
            {
                agent.RemoveSensor("Motion");
                return "הוסר Motion";
            }
            return "";
        }

        public string Magnetic()
        {
            var rank = agent.GetRank();

            return "דרגת סוכן: " + rank;
        }

        public string Signal()
        {
            return "Signal פעיל";
        }

        public string Light()
        {
            List<string> keys = agent.GetAgent().Keys.ToList();

            if (keys.Count < 2)
            {
                return "אין מספיק חיישנים";
            }
            return keys[random.Next(keys.Count)] + " , " + keys[random.Next(keys.Count)];
        }
    }

} 
