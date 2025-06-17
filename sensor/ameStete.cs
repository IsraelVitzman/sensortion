using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class GameState
    {
        private List<string> sensorsToScored = new List<string>();

        public List<string> GetScored()
        {
            return sensorsToScored;
        }

        public int GetLengthScored()
        {
            return sensorsToScored.Count;
        }

        public void AddScored(string sensor)
        {
            if (!sensorsToScored.Contains(sensor))
            {
                sensorsToScored.Add(sensor);
            }
        }

        public void RemoveScored(string sensor)
        {
            sensorsToScored.Remove(sensor);
        }

        public void ClearScored()
        {
            sensorsToScored.Clear();
        }
    }

}
