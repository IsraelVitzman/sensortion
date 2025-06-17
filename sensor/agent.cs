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
        private Random random = new Random();

        private Rank rank;
        private SensorFactory sensorFactory;

        private Dictionary<string, Func<string>> iraniAgent;


        private string selectedRankKey;
        private int selectedRankValue;

        public Agent()
        {
            rank = new Rank();
        }

        public void NewAgent()
        {
            iraniAgent = new Dictionary<string, Func<string>>();

            var rankDict = rank.GetRank();
            var randomRankIndex = random.Next(rankDict.Count);

            selectedRankKey = rankDict.Keys.ElementAt(randomRankIndex);
            selectedRankValue = rankDict[selectedRankKey];

            sensorFactory = new SensorFactory(this);

            List<string> keys = sensorFactory.GetSensorTypes();

            while (iraniAgent.Count < selectedRankValue)
            {
                int randSensorIndex = random.Next(keys.Count);

                string key = keys[randSensorIndex];

                if (!iraniAgent.ContainsKey(key))
                {
                    iraniAgent.Add(key, sensorFactory.GetSensorFactory()[key]);
                }
            }
        }

        public Dictionary<string, Func<string>> GetAgent()
        {
            return iraniAgent;
        }

        public int GetAgentLength()
        {
            return iraniAgent.Count;
        }

        public string GetRank()
        {
            return selectedRankKey;
        }

        public void RemoveSensor(string sensorType)
        {
            if (iraniAgent.ContainsKey(sensorType))
            {
                iraniAgent.Remove(sensorType);
            }
        }
    }
}
