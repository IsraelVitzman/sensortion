using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensor
{
    internal class SensorFactory
    {
        private Dictionary<string, Func<string>> sensorActions;
        private Sensor sensor;

        public SensorFactory(Agent agent)
        {
            sensor = new Sensor(agent);
            sensorActions = new Dictionary<string, Func<string>>()
            {
                { "Audio", sensor.Audio },
                { "Thermal", sensor.Thermal },
                { "Pulse", sensor.Pulse },
                { "Motion", sensor.Motion },
                { "Magnetic", sensor.Magnetic },
                { "Signal", sensor.Signal },
                { "Light", sensor.Light }
            };
        }

        public Dictionary<string, Func<string>> GetSensorFactory()
        {
            return sensorActions;
        }

        public List<string> GetSensorTypes()
        {
            return sensorActions.Keys.ToList();
        }
    }


}
